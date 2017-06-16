namespace VideoPlay
{
    partial class VideoPlayer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayer));
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.minBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.maxBtn = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.progressBarPoint = new System.Windows.Forms.PictureBox();
            this.volumeProgress = new InterfaceLandscaping.MyProgressBar();
            this.volume = new System.Windows.Forms.PictureBox();
            this.playList = new System.Windows.Forms.PictureBox();
            this.last = new System.Windows.Forms.PictureBox();
            this.next = new System.Windows.Forms.PictureBox();
            this.pause = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpVideo
            // 
            this.wmpVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(0, 0);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(640, 360);
            this.wmpVideo.TabIndex = 0;
            this.wmpVideo.MouseDownEvent += new AxWMPLib._WMPOCXEvents_MouseDownEventHandler(this.wmpVideo_MouseDownEvent);
            // 
            // titlePanel
            // 
            this.titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titlePanel.Controls.Add(this.minBtn);
            this.titlePanel.Controls.Add(this.exitBtn);
            this.titlePanel.Controls.Add(this.maxBtn);
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(641, 27);
            this.titlePanel.TabIndex = 3;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // minBtn
            // 
            this.minBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minBtn.BackgroundImage = global::VideoPlay.Properties.Resources.minimize32;
            this.minBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Location = new System.Drawing.Point(584, 5);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(16, 16);
            this.minBtn.TabIndex = 2;
            this.minBtn.UseVisualStyleBackColor = false;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exitBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitBtn.BackgroundImage = global::VideoPlay.Properties.Resources.exitBtn;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(617, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(16, 16);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.maxBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.maxBtn.BackgroundImage = global::VideoPlay.Properties.Resources.maximize432;
            this.maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBtn.Location = new System.Drawing.Point(601, 6);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(14, 14);
            this.maxBtn.TabIndex = 2;
            this.maxBtn.UseVisualStyleBackColor = false;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ControlPanel.Controls.Add(this.panel1);
            this.ControlPanel.Controls.Add(this.progressBarPoint);
            this.ControlPanel.Controls.Add(this.volumeProgress);
            this.ControlPanel.Controls.Add(this.volume);
            this.ControlPanel.Controls.Add(this.playList);
            this.ControlPanel.Controls.Add(this.last);
            this.ControlPanel.Controls.Add(this.next);
            this.ControlPanel.Controls.Add(this.pause);
            this.ControlPanel.Location = new System.Drawing.Point(0, 298);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(640, 62);
            this.ControlPanel.TabIndex = 4;
            // 
            // progressBarPoint
            // 
            this.progressBarPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarPoint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.progressBarPoint.Location = new System.Drawing.Point(557, 43);
            this.progressBarPoint.Name = "progressBarPoint";
            this.progressBarPoint.Size = new System.Drawing.Size(3, 12);
            this.progressBarPoint.TabIndex = 4;
            this.progressBarPoint.TabStop = false;
            this.progressBarPoint.Click += new System.EventHandler(this.volume_Click);
            this.progressBarPoint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.next_MouseDown);
            this.progressBarPoint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.volumeProgress_MouseUp);
            // 
            // volumeProgress
            // 
            this.volumeProgress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.volumeProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.volumeProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(147)))), ((int)(((byte)(249)))));
            this.volumeProgress.Location = new System.Drawing.Point(517, 47);
            this.volumeProgress.Name = "volumeProgress";
            this.volumeProgress.Size = new System.Drawing.Size(82, 3);
            this.volumeProgress.TabIndex = 3;
            this.volumeProgress.Click += new System.EventHandler(this.volumeProgress_Click);
            this.volumeProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.volumeProgress_MouseDown);
            this.volumeProgress.MouseUp += new System.Windows.Forms.MouseEventHandler(this.volumeProgress_MouseUp);
            // 
            // volume
            // 
            this.volume.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.volume.BackgroundImage = global::VideoPlay.Properties.Resources.volume4;
            this.volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volume.Location = new System.Drawing.Point(495, 40);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(16, 16);
            this.volume.TabIndex = 2;
            this.volume.TabStop = false;
            this.volume.Click += new System.EventHandler(this.volume_Click);
            // 
            // playList
            // 
            this.playList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.playList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playList.BackgroundImage = global::VideoPlay.Properties.Resources.threebars2;
            this.playList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playList.InitialImage = null;
            this.playList.Location = new System.Drawing.Point(586, 7);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(14, 24);
            this.playList.TabIndex = 1;
            this.playList.TabStop = false;
            this.playList.Click += new System.EventHandler(this.playList_Click);
            // 
            // last
            // 
            this.last.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.last.BackgroundImage = global::VideoPlay.Properties.Resources.last2;
            this.last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.last.Cursor = System.Windows.Forms.Cursors.Default;
            this.last.ImageLocation = "";
            this.last.Location = new System.Drawing.Point(494, 8);
            this.last.Margin = new System.Windows.Forms.Padding(0);
            this.last.Name = "last";
            this.last.Padding = new System.Windows.Forms.Padding(4);
            this.last.Size = new System.Drawing.Size(22, 22);
            this.last.TabIndex = 0;
            this.last.TabStop = false;
            this.last.Click += new System.EventHandler(this.last_Click);
            this.last.MouseDown += new System.Windows.Forms.MouseEventHandler(this.last_MouseDown);
            this.last.MouseUp += new System.Windows.Forms.MouseEventHandler(this.last_MouseUp);
            // 
            // next
            // 
            this.next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.next.BackgroundImage = global::VideoPlay.Properties.Resources.next2;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.next.Cursor = System.Windows.Forms.Cursors.Default;
            this.next.ImageLocation = "";
            this.next.Location = new System.Drawing.Point(558, 8);
            this.next.Margin = new System.Windows.Forms.Padding(0);
            this.next.Name = "next";
            this.next.Padding = new System.Windows.Forms.Padding(4);
            this.next.Size = new System.Drawing.Size(22, 22);
            this.next.TabIndex = 0;
            this.next.TabStop = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            this.next.MouseDown += new System.Windows.Forms.MouseEventHandler(this.next_MouseDown);
            this.next.MouseUp += new System.Windows.Forms.MouseEventHandler(this.next_MouseUp);
            // 
            // pause
            // 
            this.pause.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pause.BackgroundImage = global::VideoPlay.Properties.Resources.play2;
            this.pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pause.Cursor = System.Windows.Forms.Cursors.Default;
            this.pause.ImageLocation = "";
            this.pause.Location = new System.Drawing.Point(518, 0);
            this.pause.Margin = new System.Windows.Forms.Padding(0);
            this.pause.Name = "pause";
            this.pause.Padding = new System.Windows.Forms.Padding(4);
            this.pause.Size = new System.Drawing.Size(38, 38);
            this.pause.TabIndex = 0;
            this.pause.TabStop = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(340, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 18);
            this.panel1.TabIndex = 5;
            // 
            // VideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.wmpVideo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VideoPlayer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Load += new System.EventHandler(this.VideoPlayer_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VideoPlayer_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.PictureBox pause;
        private System.Windows.Forms.PictureBox last;
        private System.Windows.Forms.PictureBox next;
        private System.Windows.Forms.PictureBox playList;
        private System.Windows.Forms.PictureBox volume;
        private InterfaceLandscaping.MyProgressBar volumeProgress;
        private System.Windows.Forms.PictureBox progressBarPoint;
        private System.Windows.Forms.Panel panel1;
    }
}

