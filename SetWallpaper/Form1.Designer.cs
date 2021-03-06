﻿namespace SetWallpaper
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetWallpaper = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatut = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.radTile = new System.Windows.Forms.RadioButton();
            this.radStretch = new System.Windows.Forms.RadioButton();
            this.radCenter = new System.Windows.Forms.RadioButton();
            this.radFill = new System.Windows.Forms.RadioButton();
            this.radFit = new System.Windows.Forms.RadioButton();
            this.logViewer = new NetworkCore.Control.LogViewer();
            this.btnSendWallpaper = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetWallpaper,
            this.toolStripMenuItem2,
            this.mnuConnect,
            this.mnuFindServer,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuSetWallpaper
            // 
            this.mnuSetWallpaper.Name = "mnuSetWallpaper";
            this.mnuSetWallpaper.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnuSetWallpaper.Size = new System.Drawing.Size(191, 22);
            this.mnuSetWallpaper.Text = "Set &Wallpaper";
            this.mnuSetWallpaper.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(188, 6);
            // 
            // mnuConnect
            // 
            this.mnuConnect.Name = "mnuConnect";
            this.mnuConnect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuConnect.Size = new System.Drawing.Size(191, 22);
            this.mnuConnect.Text = "Connect";
            this.mnuConnect.Click += new System.EventHandler(this.mnuConnect_Click);
            // 
            // mnuFindServer
            // 
            this.mnuFindServer.Name = "mnuFindServer";
            this.mnuFindServer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuFindServer.Size = new System.Drawing.Size(191, 22);
            this.mnuFindServer.Text = "Find a server";
            this.mnuFindServer.Click += new System.EventHandler(this.mnuFindServer_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(191, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatut,
            this.pgbProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(679, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatut
            // 
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(39, 17);
            this.lblStatut.Text = "Ready";
            // 
            // pgbProgress
            // 
            this.pgbProgress.MarqueeAnimationSpeed = 65;
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(50, 16);
            this.pgbProgress.Visible = false;
            // 
            // radTile
            // 
            this.radTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radTile.AutoSize = true;
            this.radTile.Location = new System.Drawing.Point(425, 326);
            this.radTile.Name = "radTile";
            this.radTile.Size = new System.Drawing.Size(42, 17);
            this.radTile.TabIndex = 3;
            this.radTile.Text = "Tile";
            this.radTile.UseVisualStyleBackColor = true;
            this.radTile.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radStretch
            // 
            this.radStretch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radStretch.AutoSize = true;
            this.radStretch.Location = new System.Drawing.Point(535, 326);
            this.radStretch.Name = "radStretch";
            this.radStretch.Size = new System.Drawing.Size(59, 17);
            this.radStretch.TabIndex = 4;
            this.radStretch.TabStop = true;
            this.radStretch.Text = "Stretch";
            this.radStretch.UseVisualStyleBackColor = true;
            this.radStretch.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radCenter
            // 
            this.radCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radCenter.AutoSize = true;
            this.radCenter.Checked = true;
            this.radCenter.Location = new System.Drawing.Point(473, 326);
            this.radCenter.Name = "radCenter";
            this.radCenter.Size = new System.Drawing.Size(56, 17);
            this.radCenter.TabIndex = 5;
            this.radCenter.TabStop = true;
            this.radCenter.Text = "Center";
            this.radCenter.UseVisualStyleBackColor = true;
            this.radCenter.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radFill
            // 
            this.radFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radFill.AutoSize = true;
            this.radFill.Location = new System.Drawing.Point(382, 326);
            this.radFill.Name = "radFill";
            this.radFill.Size = new System.Drawing.Size(37, 17);
            this.radFill.TabIndex = 6;
            this.radFill.Text = "Fill";
            this.radFill.UseVisualStyleBackColor = true;
            this.radFill.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radFit
            // 
            this.radFit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radFit.AutoSize = true;
            this.radFit.Location = new System.Drawing.Point(340, 326);
            this.radFit.Name = "radFit";
            this.radFit.Size = new System.Drawing.Size(36, 17);
            this.radFit.TabIndex = 7;
            this.radFit.Text = "Fit";
            this.radFit.UseVisualStyleBackColor = true;
            this.radFit.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // logViewer
            // 
            this.logViewer.AllowNavigation = false;
            this.logViewer.AllowWebBrowserDrop = false;
            this.logViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logViewer.DateFormat = "yyyy/MM/dd | HH:mm:ss";
            this.logViewer.IsWebBrowserContextMenuEnabled = false;
            this.logViewer.Location = new System.Drawing.Point(0, 26);
            this.logViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.logViewer.Name = "logViewer";
            this.logViewer.ScriptErrorsSuppressed = true;
            this.logViewer.Size = new System.Drawing.Size(679, 294);
            this.logViewer.StyleSheet = "/Style/log.css";
            this.logViewer.TabIndex = 1;
            this.logViewer.WebBrowserShortcutsEnabled = false;
            // 
            // btnSendWallpaper
            // 
            this.btnSendWallpaper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendWallpaper.Location = new System.Drawing.Point(600, 324);
            this.btnSendWallpaper.Name = "btnSendWallpaper";
            this.btnSendWallpaper.Size = new System.Drawing.Size(57, 20);
            this.btnSendWallpaper.TabIndex = 8;
            this.btnSendWallpaper.Text = "Send...";
            this.btnSendWallpaper.UseVisualStyleBackColor = true;
            this.btnSendWallpaper.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 345);
            this.Controls.Add(this.btnSendWallpaper);
            this.Controls.Add(this.radFit);
            this.Controls.Add(this.radFill);
            this.Controls.Add(this.radCenter);
            this.Controls.Add(this.radStretch);
            this.Controls.Add(this.radTile);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.logViewer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Wallpaper Sync";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.DragLeave += new System.EventHandler(this.Form1_DragLeave);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFindServer;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private NetworkCore.Control.LogViewer logViewer;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblStatut;
		private System.Windows.Forms.ToolStripProgressBar pgbProgress;
		private System.Windows.Forms.ToolStripMenuItem mnuSetWallpaper;
		private System.Windows.Forms.RadioButton radTile;
		private System.Windows.Forms.RadioButton radStretch;
		private System.Windows.Forms.RadioButton radCenter;
        private System.Windows.Forms.RadioButton radFill;
        private System.Windows.Forms.RadioButton radFit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuConnect;
        private System.Windows.Forms.Button btnSendWallpaper;
    }
}

