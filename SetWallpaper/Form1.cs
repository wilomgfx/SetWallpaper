﻿using NetworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NetworkCore.Control;

namespace SetWallpaper
{
    public partial class Form1 : Form
    {
        private ClientManager m_client;
        private Wallpaper.Style m_wallpaperStyle;
        private Panel m_overlay;

        private bool IsConnected { get { return m_client != null; } }

        private string Statut
        {
            get { return lblStatut.Text; }
            set { lblStatut.Text = value; }
        }

        public Form1()
        {
            InitializeComponent();
            UpdateUIState();
            Statut = "Not connected";
            m_wallpaperStyle = Wallpaper.Style.Center;
            radCenter.Checked = true;
            logViewer.Document.Body.DragOver += Body_DragOver;
        }

        void Body_DragOver(object sender, HtmlElementEventArgs e)
        {
            if(IsConnected)
                ShowOverlay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfDiag = new OpenFileDialog();
            opfDiag.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";


            if (opfDiag.ShowDialog() == DialogResult.OK)
            {
                SendWallpaper(opfDiag.FileName);
            }
        }

        private void SendWallpaper(string path)
        {
            try
            {
                Image image = Image.FromFile(path);
                logViewer.WriteLine("Sending " + Path.GetFileName(path) + " to server...");
                Statut = "Sending " + Path.GetFileName(path) + " to server...";
                m_client.SendImage(image, m_wallpaperStyle);
                Statut = "Image " + Path.GetFileName(path) + " successfully sent";
            }
            catch (ArgumentException ex)
            {
                logViewer.WriteLine("Selected image is invalid:" + Environment.NewLine + ex.Message, MessageType.Error);
                Statut = "Error with file: " + path;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bool isConnected = m_client.FindServer(m_client.Port);

            if (InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    ConnectionFound(isConnected);
                });
            }
            else
            {
                ConnectionFound(isConnected);
            }

        }

        private void ConnectionFound(bool isConnected)
        {
            pgbProgress.Visible = false;
            mnuConnect.Enabled = true;

            if (!isConnected)
            {
                logViewer.WriteLine("No server found", MessageType.Error);
                Statut = "No server found";
                m_client.Disconnect();
                m_client = null;
            }
            else
            {
                logViewer.WriteLine("Connected to server " + m_client.Ip + ":" + m_client.Port);
                Statut = "Connected to server " + m_client.Ip + ":" + m_client.Port;
                m_client.OnDisconnected += m_client_OnDisconnected;
                m_client.OnNotificationReceived += m_client_OnNotificationReceived;
                m_client.OnWallPaperReceived += m_client_OnWallPaperReceived;
                logViewer.WriteLine("Ready to receive a wallpaper");
            }

            UpdateUIState();
        }

        void m_client_OnWallPaperReceived(object sender, WallpaperReceivedArgs e)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    OnWallPaperReceived(e);
                });
            }
            else
            {
                OnWallPaperReceived(e);
            }
        }

        private void OnWallPaperReceived(WallpaperReceivedArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "temp_wallpaper.wllpr");

            if (File.Exists(path))
                File.Delete(path);

            logViewer.WriteLine(e.Image, "New wallpaper received (" + e.Style + "):");

            e.Image.Save(path);
            e.Image.Dispose();
            Wallpaper.Set(new Uri(path), e.Style);
            File.Delete(path);
        }

        void m_client_OnNotificationReceived(object sender, NotificationReceivedArgs e)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    OnNotificationReceived(e);
                });
            }
            else
            {
                OnNotificationReceived(e);
            }
        }

        private void OnNotificationReceived(NotificationReceivedArgs e)
        {
            logViewer.WriteLine(e.Message, MessageType.Notification);
        }

        void m_client_OnDisconnected(object sender, AltarNet.TcpEventArgs e)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    OnDisconnected();
                });
            }
            else
            {
                OnDisconnected();
            }

        }

        private void UpdateUIState()
        {
            if (IsConnected)
            {
                mnuFindServer.Enabled = false;
                mnuConnect.Text = "Disconnect";
            }
            else
            {
                mnuFindServer.Enabled = true;
                mnuConnect.Text = "Connect...";
            }
            mnuSetWallpaper.Enabled = IsConnected;
        }

        private void OnDisconnected()
        {
            if (m_client == null)
                return;

            logViewer.WriteLine("Connection lost with " + m_client.Ip + ":" + m_client.Port, MessageType.Error);
            Statut = "Connection lost with " + m_client.Ip + ":" + m_client.Port;
            m_client = null;
            UpdateUIState();
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)sender;

            if (rad.Checked)
            {
                switch (rad.Name)
                {
                    case "radTile":
                        m_wallpaperStyle = Wallpaper.Style.Tile;
                        break;
                    case "radCenter":
                        m_wallpaperStyle = Wallpaper.Style.Center;
                        break;
                    case "radStretch":
                        m_wallpaperStyle = Wallpaper.Style.Stretch;
                        break;
                    case "radFit":
                        m_wallpaperStyle = Wallpaper.Style.Fit;
                        break;
                    case "radFill":
                        m_wallpaperStyle = Wallpaper.Style.Fill;
                        break;
                }
            }

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            //e.Effect = DragDropEffects.Copy;
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (FileList.Length > 0)
            {
                SendWallpaper(FileList[0]);
            }

            HideOverlay();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (!IsConnected)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                ShowOverlay();
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragLeave(object sender, EventArgs e)
        {
            HideOverlay();
        }

        private void ShowOverlay()
        {
            if (m_overlay != null)
                return;

            m_overlay = new Panel();
            m_overlay.Dock = System.Windows.Forms.DockStyle.Fill;
            m_overlay.Location = new System.Drawing.Point(0, 24);
            m_overlay.Name = "overlay";
            m_overlay.Size = new System.Drawing.Size(598, 245);
            m_overlay.TabIndex = 8;
            m_overlay.BackColor = SystemColors.Control;
            this.Controls.Add(m_overlay);
            m_overlay.BringToFront();
        }

        private void HideOverlay()
        {
            if (m_overlay == null)
                return;
            this.Controls.Remove(m_overlay);
            m_overlay = null;

        }

        private void mnuConnect_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                new frmConnect(this).ShowDialog();
            }
            else
            {
                m_client.Disconnect();
                m_client = null;
                logViewer.WriteLine("You have been disconnected from the server");
                Statut = "Successfully disconnected";
                UpdateUIState();
            }
        }
        private void mnuFindServer_Click(object sender, EventArgs e)
        {
            if (IsConnected)
                return;

            logViewer.WriteLine("Looking for server...");
            Statut = "Finding a server to connect...";
            pgbProgress.Visible = true;
            pgbProgress.Style = ProgressBarStyle.Marquee;
            mnuFindServer.Enabled = false;
            mnuConnect.Enabled = false;
            m_client = new ClientManager();

            backgroundWorker1.RunWorkerAsync();

        }

        public async void Connect(IPAddress ip, int port)
        {
            if (IsConnected)
                return;

            logViewer.WriteLine("Connecting to " + ip + ":" + port + "...");
            Statut = "Connecting to " + ip + ":" + port + "...";

            m_client = new ClientManager(ip, port);
            pgbProgress.Visible = true;
            mnuConnect.Enabled = false;
            mnuFindServer.Enabled = false;

            bool isConnected = await m_client.ConnectAsync();

            ConnectionFound(isConnected);
        }

    }
}
