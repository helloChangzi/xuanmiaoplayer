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
            this.controlPanel = new System.Windows.Forms.Panel();
            this.totalTimeShow = new System.Windows.Forms.TextBox();
            this.CurrentTimeShow = new System.Windows.Forms.TextBox();
            this.volumeProgressPanel = new System.Windows.Forms.Panel();
            this.volumeProgressBarPoint = new System.Windows.Forms.PictureBox();
            this.volumeProgressBar = new InterfaceLandscaping.MyProgressBar();
            this.videoProgressPanel = new System.Windows.Forms.Panel();
            this.videoProgressBarPoint = new System.Windows.Forms.PictureBox();
            this.videoProgressBar = new InterfaceLandscaping.MyProgressBar();
            this.videoTitle = new System.Windows.Forms.TextBox();
            this.volume = new System.Windows.Forms.PictureBox();
            this.OpenPlayList = new System.Windows.Forms.PictureBox();
            this.last = new System.Windows.Forms.PictureBox();
            this.next = new System.Windows.Forms.PictureBox();
            this.pause = new System.Windows.Forms.PictureBox();
            this.PlayListMainPanel = new System.Windows.Forms.Panel();
            this.exitBtn2 = new System.Windows.Forms.Button();
            this.addToList = new System.Windows.Forms.PictureBox();
            this.PlayListPanel = new System.Windows.Forms.Panel();
            this.myCollection = new System.Windows.Forms.Label();
            this.myComputer = new System.Windows.Forms.Label();
            this.historyList = new System.Windows.Forms.Label();
            this.PlayListTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.volumeProgressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeProgressBarPoint)).BeginInit();
            this.videoProgressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoProgressBarPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenPlayList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            this.PlayListMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addToList)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpVideo
            // 
            this.wmpVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(0, 0);
            this.wmpVideo.Margin = new System.Windows.Forms.Padding(0);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(640, 360);
            this.wmpVideo.TabIndex = 0;
            this.wmpVideo.UseWaitCursor = true;
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
            this.titlePanel.Visible = false;
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
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.controlPanel.Controls.Add(this.totalTimeShow);
            this.controlPanel.Controls.Add(this.CurrentTimeShow);
            this.controlPanel.Controls.Add(this.volumeProgressPanel);
            this.controlPanel.Controls.Add(this.videoProgressPanel);
            this.controlPanel.Controls.Add(this.videoTitle);
            this.controlPanel.Controls.Add(this.volume);
            this.controlPanel.Controls.Add(this.OpenPlayList);
            this.controlPanel.Controls.Add(this.last);
            this.controlPanel.Controls.Add(this.next);
            this.controlPanel.Controls.Add(this.pause);
            this.controlPanel.Location = new System.Drawing.Point(0, 298);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(640, 62);
            this.controlPanel.TabIndex = 4;
            // 
            // totalTimeShow
            // 
            this.totalTimeShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTimeShow.BackColor = System.Drawing.SystemColors.InfoText;
            this.totalTimeShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalTimeShow.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalTimeShow.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.totalTimeShow.Location = new System.Drawing.Point(378, 39);
            this.totalTimeShow.Margin = new System.Windows.Forms.Padding(0);
            this.totalTimeShow.Name = "totalTimeShow";
            this.totalTimeShow.ReadOnly = true;
            this.totalTimeShow.Size = new System.Drawing.Size(55, 18);
            this.totalTimeShow.TabIndex = 8;
            this.totalTimeShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CurrentTimeShow
            // 
            this.CurrentTimeShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentTimeShow.BackColor = System.Drawing.SystemColors.InfoText;
            this.CurrentTimeShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentTimeShow.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CurrentTimeShow.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.CurrentTimeShow.Location = new System.Drawing.Point(48, 39);
            this.CurrentTimeShow.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentTimeShow.Name = "CurrentTimeShow";
            this.CurrentTimeShow.ReadOnly = true;
            this.CurrentTimeShow.Size = new System.Drawing.Size(55, 18);
            this.CurrentTimeShow.TabIndex = 7;
            // 
            // volumeProgressPanel
            // 
            this.volumeProgressPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.volumeProgressPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.volumeProgressPanel.Controls.Add(this.volumeProgressBarPoint);
            this.volumeProgressPanel.Controls.Add(this.volumeProgressBar);
            this.volumeProgressPanel.Location = new System.Drawing.Point(517, 42);
            this.volumeProgressPanel.Name = "volumeProgressPanel";
            this.volumeProgressPanel.Size = new System.Drawing.Size(82, 12);
            this.volumeProgressPanel.TabIndex = 6;
            this.volumeProgressPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.volumeProgressPanel_MouseDown);
            this.volumeProgressPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.volumeProgressPanel_MouseMove);
            this.volumeProgressPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.volumeProgressPanel_MouseUp);
            // 
            // volumeProgressBarPoint
            // 
            this.volumeProgressBarPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeProgressBarPoint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.volumeProgressBarPoint.Location = new System.Drawing.Point(79, 0);
            this.volumeProgressBarPoint.Name = "volumeProgressBarPoint";
            this.volumeProgressBarPoint.Size = new System.Drawing.Size(3, 12);
            this.volumeProgressBarPoint.TabIndex = 7;
            this.volumeProgressBarPoint.TabStop = false;
            this.volumeProgressBarPoint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.volumeProgressPanel_MouseDown);
            this.volumeProgressBarPoint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.volumeProgressPanel_MouseMove);
            this.volumeProgressBarPoint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.volumeProgressPanel_MouseUp);
            // 
            // volumeProgressBar
            // 
            this.volumeProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.volumeProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(147)))), ((int)(((byte)(249)))));
            this.volumeProgressBar.Location = new System.Drawing.Point(0, 4);
            this.volumeProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.volumeProgressBar.Name = "volumeProgressBar";
            this.volumeProgressBar.Size = new System.Drawing.Size(82, 3);
            this.volumeProgressBar.TabIndex = 0;
            this.volumeProgressBar.Value = 100;
            this.volumeProgressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.volumeProgressPanel_MouseDown);
            this.volumeProgressBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.volumeProgressPanel_MouseMove);
            this.volumeProgressBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.volumeProgressPanel_MouseUp);
            // 
            // videoProgressPanel
            // 
            this.videoProgressPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.videoProgressPanel.Controls.Add(this.videoProgressBarPoint);
            this.videoProgressPanel.Controls.Add(this.videoProgressBar);
            this.videoProgressPanel.Location = new System.Drawing.Point(48, 22);
            this.videoProgressPanel.Name = "videoProgressPanel";
            this.videoProgressPanel.Size = new System.Drawing.Size(385, 22);
            this.videoProgressPanel.TabIndex = 5;
            this.videoProgressPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.videoProgressPanel_MouseDown);
            this.videoProgressPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.videoProgressPanel_MouseMove);
            this.videoProgressPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.videoProgressPanel_MouseUp);
            // 
            // videoProgressBarPoint
            // 
            this.videoProgressBarPoint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.videoProgressBarPoint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.videoProgressBarPoint.Location = new System.Drawing.Point(0, 5);
            this.videoProgressBarPoint.Name = "videoProgressBarPoint";
            this.videoProgressBarPoint.Size = new System.Drawing.Size(4, 12);
            this.videoProgressBarPoint.TabIndex = 6;
            this.videoProgressBarPoint.TabStop = false;
            this.videoProgressBarPoint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.videoProgressPanel_MouseDown);
            this.videoProgressBarPoint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.videoProgressPanel_MouseMove);
            this.videoProgressBarPoint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.videoProgressPanel_MouseUp);
            // 
            // videoProgressBar
            // 
            this.videoProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.videoProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.videoProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(147)))), ((int)(((byte)(249)))));
            this.videoProgressBar.Location = new System.Drawing.Point(0, 9);
            this.videoProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.videoProgressBar.Name = "videoProgressBar";
            this.videoProgressBar.Size = new System.Drawing.Size(385, 4);
            this.videoProgressBar.TabIndex = 0;
            this.videoProgressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.videoProgressPanel_MouseDown);
            this.videoProgressBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.videoProgressPanel_MouseMove);
            this.videoProgressBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.videoProgressPanel_MouseUp);
            // 
            // videoTitle
            // 
            this.videoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.videoTitle.BackColor = System.Drawing.SystemColors.InfoText;
            this.videoTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.videoTitle.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.videoTitle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.videoTitle.Location = new System.Drawing.Point(48, 5);
            this.videoTitle.Margin = new System.Windows.Forms.Padding(0);
            this.videoTitle.Name = "videoTitle";
            this.videoTitle.ReadOnly = true;
            this.videoTitle.Size = new System.Drawing.Size(385, 18);
            this.videoTitle.TabIndex = 1;
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
            // OpenPlayList
            // 
            this.OpenPlayList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OpenPlayList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpenPlayList.BackgroundImage = global::VideoPlay.Properties.Resources.threebars2;
            this.OpenPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenPlayList.InitialImage = null;
            this.OpenPlayList.Location = new System.Drawing.Point(586, 7);
            this.OpenPlayList.Name = "OpenPlayList";
            this.OpenPlayList.Size = new System.Drawing.Size(14, 24);
            this.OpenPlayList.TabIndex = 1;
            this.OpenPlayList.TabStop = false;
            this.OpenPlayList.Click += new System.EventHandler(this.playList_Click);
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
            // PlayListMainPanel
            // 
            this.PlayListMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayListMainPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayListMainPanel.Controls.Add(this.exitBtn2);
            this.PlayListMainPanel.Controls.Add(this.addToList);
            this.PlayListMainPanel.Controls.Add(this.PlayListPanel);
            this.PlayListMainPanel.Controls.Add(this.myCollection);
            this.PlayListMainPanel.Controls.Add(this.myComputer);
            this.PlayListMainPanel.Controls.Add(this.historyList);
            this.PlayListMainPanel.Controls.Add(this.PlayListTitle);
            this.PlayListMainPanel.Location = new System.Drawing.Point(439, 0);
            this.PlayListMainPanel.Name = "PlayListMainPanel";
            this.PlayListMainPanel.Size = new System.Drawing.Size(201, 360);
            this.PlayListMainPanel.TabIndex = 5;
            this.PlayListMainPanel.Visible = false;
            // 
            // exitBtn2
            // 
            this.exitBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitBtn2.BackgroundImage = global::VideoPlay.Properties.Resources.exitBtn;
            this.exitBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn2.Location = new System.Drawing.Point(174, 6);
            this.exitBtn2.Name = "exitBtn2";
            this.exitBtn2.Size = new System.Drawing.Size(16, 16);
            this.exitBtn2.TabIndex = 3;
            this.exitBtn2.UseVisualStyleBackColor = false;
            this.exitBtn2.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addToList
            // 
            this.addToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addToList.BackgroundImage = global::VideoPlay.Properties.Resources.add;
            this.addToList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addToList.Location = new System.Drawing.Point(13, 336);
            this.addToList.Margin = new System.Windows.Forms.Padding(0);
            this.addToList.Name = "addToList";
            this.addToList.Size = new System.Drawing.Size(14, 14);
            this.addToList.TabIndex = 5;
            this.addToList.TabStop = false;
            this.addToList.Click += new System.EventHandler(this.addToList_Click);
            // 
            // PlayListPanel
            // 
            this.PlayListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayListPanel.AutoScroll = true;
            this.PlayListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.PlayListPanel.Location = new System.Drawing.Point(0, 48);
            this.PlayListPanel.Name = "PlayListPanel";
            this.PlayListPanel.Size = new System.Drawing.Size(201, 280);
            this.PlayListPanel.TabIndex = 4;
            // 
            // myCollection
            // 
            this.myCollection.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myCollection.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myCollection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.myCollection.Location = new System.Drawing.Point(134, 24);
            this.myCollection.Name = "myCollection";
            this.myCollection.Size = new System.Drawing.Size(67, 24);
            this.myCollection.TabIndex = 3;
            this.myCollection.Text = "我的收藏";
            this.myCollection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.myCollection.Click += new System.EventHandler(this.myCollection_Click);
            // 
            // myComputer
            // 
            this.myComputer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myComputer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myComputer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.myComputer.Location = new System.Drawing.Point(67, 24);
            this.myComputer.Name = "myComputer";
            this.myComputer.Size = new System.Drawing.Size(67, 24);
            this.myComputer.TabIndex = 2;
            this.myComputer.Text = "此电脑";
            this.myComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.myComputer.Click += new System.EventHandler(this.myComputer_Click);
            // 
            // historyList
            // 
            this.historyList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.historyList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.historyList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.historyList.Location = new System.Drawing.Point(0, 24);
            this.historyList.Name = "historyList";
            this.historyList.Size = new System.Drawing.Size(67, 24);
            this.historyList.TabIndex = 1;
            this.historyList.Text = "历史纪录";
            this.historyList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.historyList.Click += new System.EventHandler(this.historyList_Click);
            // 
            // PlayListTitle
            // 
            this.PlayListTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayListTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayListTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayListTitle.Location = new System.Drawing.Point(0, 0);
            this.PlayListTitle.Name = "PlayListTitle";
            this.PlayListTitle.Size = new System.Drawing.Size(84, 24);
            this.PlayListTitle.TabIndex = 0;
            this.PlayListTitle.Text = "播放列表";
            this.PlayListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VideoPlayer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.PlayListMainPanel);
            this.Controls.Add(this.controlPanel);
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
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.volumeProgressPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volumeProgressBarPoint)).EndInit();
            this.videoProgressPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoProgressBarPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenPlayList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            this.PlayListMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addToList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.PictureBox pause;
        private System.Windows.Forms.PictureBox last;
        private System.Windows.Forms.PictureBox next;
        private System.Windows.Forms.PictureBox OpenPlayList;
        private System.Windows.Forms.PictureBox volume;
        private System.Windows.Forms.TextBox videoTitle;
        private InterfaceLandscaping.MyProgressBar videoProgressBar;
        private System.Windows.Forms.Panel videoProgressPanel;
        private System.Windows.Forms.Panel volumeProgressPanel;
        private System.Windows.Forms.PictureBox volumeProgressBarPoint;
        private InterfaceLandscaping.MyProgressBar volumeProgressBar;
        private System.Windows.Forms.PictureBox videoProgressBarPoint;
        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private System.Windows.Forms.Panel PlayListMainPanel;
        private System.Windows.Forms.Label PlayListTitle;
        private System.Windows.Forms.Panel PlayListPanel;
        private System.Windows.Forms.Label myCollection;
        private System.Windows.Forms.Label myComputer;
        private System.Windows.Forms.Label historyList;
        private System.Windows.Forms.PictureBox addToList;
        private System.Windows.Forms.Button exitBtn2;
        private System.Windows.Forms.TextBox CurrentTimeShow;
        private System.Windows.Forms.TextBox totalTimeShow;
    }
}

