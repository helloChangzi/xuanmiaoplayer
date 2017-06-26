using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoPlay
{
    public partial class VideoPlayer : Form
    {
        public VideoPlayer()
        {
            InitializeComponent();
        }

        System.Timers.Timer PlayElementsChange;
        System.Timers.Timer playListShow;
        Boolean PLAYFLAG =false;
        Boolean PLAYLISTFLAG = false;
        private void VideoPlayer_Load(object sender, EventArgs e1)
        {
            //全局快捷键
            kh = new KeyboardHook();
            kh.SetHook();
            kh.OnKeyDownEvent += kh_OnKeyDownEvent;

            //去掉wmp自带功能按钮
            wmpVideo.uiMode = "none";
            //调用鼠标移入显示标题栏方法的定时器
            System.Timers.Timer titleShow;
            titleShow = new System.Timers.Timer(100);//定时周期0.1秒
            titleShow.Elapsed += titleBarInJudge;//到1秒了做的事件
            titleShow.AutoReset = true; //是否不断重复定时器操作
            titleShow.Enabled = true;

            //调用鼠标移入显示控制栏方法的定时器
            System.Timers.Timer controlBarShow;
            controlBarShow = new System.Timers.Timer(100);//定时周期0.1秒
            controlBarShow.Elapsed += controlBarInJudge;//到1秒了做的事件
            controlBarShow.AutoReset = true; //是否不断重复定时器操作
            controlBarShow.Enabled = true;

            //调用鼠标移入显示播放列表方法的定时器
            playListShow = new System.Timers.Timer(100);//定时周期0.1秒
            playListShow.Elapsed += playListInJudge;//到1秒了做的事件
            playListShow.AutoReset = true; //是否不断重复定时器操作
            playListShow.Enabled = true;

            //播放进度实时改变的定时器
            PlayElementsChange = new System.Timers.Timer(1000);//定时周期0.1秒
            PlayElementsChange.Elapsed += PlayProgressChange;//到1秒了做的事件
            PlayElementsChange.AutoReset = true; //是否不断重复定时器操作
            PlayElementsChange.Enabled = true;

            #region  拖文件到VideoPlay上直接播放视屏
            DragEnter += (s, e) =>
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.None;
            };
            DragDrop += (s, e) =>
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    var file = files.FirstOrDefault();
                    if (!string.IsNullOrWhiteSpace(file))
                    {
                        PlayRealTimeChange(file);
                    }
                }
            };
            #endregion

            PlayButtonCorrect();
            GetHistoryList();
            playListAdd(HistoryList);
            playListShow.Stop();
        }

        #region 快捷键
        KeyboardHook kh;
        void kh_OnKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.S | Keys.Control)) { this.Show(); }//Ctrl+S显示窗口
            if (e.KeyData == (Keys.H | Keys.Control)) { this.Hide(); }//Ctrl+H隐藏窗口
            if (e.KeyData == (Keys.Space)) { pause_Click(sender, e); }//Ctrl+C 关闭窗口 
            if (e.KeyData == (Keys.A | Keys.Control | Keys.Alt)) { this.Text = "你发现了什么？"; }//Ctrl+Alt+A
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            kh.UnHook();
        }
        #endregion

        #region 播放列表移入显示移出隐藏
        void playListInJudge(object sender, System.Timers.ElapsedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            //鼠标相对于屏幕的坐标
            p1 = MousePosition;
            //鼠标相对于窗体的坐标
            p2 = this.PointToClient(p1);
            int x = p2.X;
            int y = p2.Y;
            if (x > ClientRectangle.Width - PlayListMainPanel.Width && x < ClientRectangle.Width && y < ClientRectangle.Height * 0.6 && y > ClientRectangle.Height * 0.4 || x > ClientRectangle.Width * 0.95 && x < ClientRectangle.Width && y < ClientRectangle.Height * 0.8 && y > ClientRectangle.Height * 0.2)
            {
                PlayListMainPanel.Visible = true;
            }
            if (x > 0 && x < ClientRectangle.Width - PlayListMainPanel.Width || x > ClientRectangle.Width)
            {
                PlayListMainPanel.Visible = false;
            }
        }


        #endregion

        #region 标题栏移入显示移出隐藏
        void titleBarInJudge(object sender, System.Timers.ElapsedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            //鼠标相对于屏幕的坐标
            p1 = MousePosition;
            //鼠标相对于窗体的坐标
            p2 = this.PointToClient(p1);
            int x = p2.X;
            int y = p2.Y;
            if (x > 0 && x < titlePanel.Width && y > 0 && y < titlePanel.Height)
            {
                titlePanel.Visible = true;
            }
            else
            {
                titlePanel.Visible = false;
            }
        }
        #endregion

        #region 控制栏移入显示移出隐藏
        void controlBarInJudge(object sender, System.Timers.ElapsedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            //鼠标相对于屏幕的坐标
            Point p1 = MousePosition;
            //鼠标相对于窗体的坐标
            Point p2 = this.PointToClient(p1);
            int x = p2.X;
            int y = p2.Y;
            if (x > 0 && x < controlPanel.Width && y > ClientRectangle.Height - controlPanel.Height && y < ClientRectangle.Height)
            {
                controlPanel.Visible = true;
            }
            else
            {
                controlPanel.Visible = false;
            }
        }
        #endregion

        #region 鼠标拖动主界面
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private void VideoPlayer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void wmpVideo_MouseDownEvent(object sender, AxWMPLib._WMPOCXEvents_MouseDownEvent e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion

        #region 标题栏按钮
        //标题栏关闭按钮
        private void exitBtn_Click(object sender, EventArgs e)
        {
            //保存历史纪录
            SaveHistoryList(true);
            this.Close();
        }
        //标题栏最大化按钮
        private void maxBtn_Click(object sender, EventArgs e)
        {
            this.wmpVideo.stretchToFit = true;
            if (this.WindowState == FormWindowState.Maximized)
            {
                // 如果窗口已经最大化，则恢恢复为正常大小 
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                // 否则，窗口为正常时，将其最大化 
                this.WindowState = FormWindowState.Maximized;
            }
        }
        //标题栏最小化按钮
        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region 播放控制栏
        #region 暂停开始按钮
        public void PlayButtonCorrect()
        {
            //播放按钮纠正
            if (wmpVideo.playState == WMPLib.WMPPlayState.wmppsPaused)//是否暂停
            {
                pause.BackgroundImage = Image.FromFile("../../image/pause2.png");
            }
            else if (wmpVideo.playState == WMPLib.WMPPlayState.wmppsPlaying)//是否播放
            {
                PlayFlag = true;
                pause.BackgroundImage = Image.FromFile("../../image/play2.png");
            }
            else
            {
                PlayFlag = false;
                pause.BackgroundImage = Image.FromFile("../../image/pause2.png");
            }
        }
        private Boolean flag = false;
        public bool PlayFlag { get => flag; set => flag = value; }
        public void switchPlayAndPause()
        {
            PlayButtonCorrect();
            //播放按钮切换
            PlayFlag = !PlayFlag;
            if (PlayFlag)
            {
                pause.BackgroundImage = Image.FromFile("../../image/pause2.png");
            }
            else
            {
                pause.BackgroundImage = Image.FromFile("../../image/play2.png");
            }
            //播放状态切换
            if ((int)wmpVideo.playState == 2)//是否暂停
                wmpVideo.Ctlcontrols.play();
            else if ((int)wmpVideo.playState == 3)//是否播放
                wmpVideo.Ctlcontrols.pause();
            else
            {
                //System.Console.WriteLine(wmpVideo.playState);
                wmpVideo.Ctlcontrols.pause();
            }
        }
        private void pause_Click(object sender, EventArgs e)
        {
            switchPlayAndPause();
        }
        #endregion

        #region 上一首和下一首
        //上一首
        private void last_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.previous();
        }
        //下一首
        private void next_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.next();
        }
        #endregion

        #region 快进

        #region 返回时间差
        public static float TimeDiff(DateTime DateTime1, DateTime DateTime2)
        {
            float timeDiff = 0;
            TimeSpan ts1 = new TimeSpan(DateTime1.Ticks);
            TimeSpan ts2 = new TimeSpan(DateTime2.Ticks);
            TimeSpan ts = ts1.Subtract(ts2).Duration();
            timeDiff = ts.Seconds;
            return timeDiff;
        }
        #endregion
        System.Timers.Timer kuaijinTimer;
        private DateTime mouseClickTime;
        private void next_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClickTime = DateTime.Now;
            kuaijinTimer = new System.Timers.Timer(50);//定时周期0.1秒
            kuaijinTimer.Elapsed += kuaijin;//到1秒了做的事件
            kuaijinTimer.AutoReset = true; //是否不断重复定时器操作
            kuaijinTimer.Enabled = true;
        }
        //按下鼠标超过0.05秒就快进
        void kuaijin(object sender, System.Timers.ElapsedEventArgs e)
        {
            float timeDiff;
            timeDiff = TimeDiff(DateTime.Now, mouseClickTime);
            if (timeDiff > 0.1)
            {
                //wmpVideo.Ctlcontrols.fastForward();
                wmpVideo.settings.rate = 3.0;
            }
        }
        private void next_MouseUp(object sender, MouseEventArgs e)
        {
            wmpVideo.settings.rate = 1;
            if ((int)wmpVideo.playState != 3)//是否不播放
                wmpVideo.Ctlcontrols.play();
            kuaijinTimer.Dispose();
        }
        #endregion

        #region 快退
        System.Timers.Timer kuaituiTimer;
        //按下鼠标超过0.05秒就快退
        private void last_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClickTime = DateTime.Now;
            kuaituiTimer = new System.Timers.Timer(50);//定时周期0.1秒
            kuaituiTimer.Elapsed += kuaitui;//到0.1秒了做的事件
            kuaituiTimer.AutoReset = true; //是否不断重复定时器操作
            kuaituiTimer.Enabled = true;
        }
        //按下鼠标超过0.1秒就快退
        void kuaitui(object sender, System.Timers.ElapsedEventArgs e)
        {
            float timeDiff;
            timeDiff = TimeDiff(DateTime.Now, mouseClickTime);
            if (timeDiff > 0.1)
            {
                if ((int)wmpVideo.playState != 3)//是否不播放
                    wmpVideo.Ctlcontrols.play();
                wmpVideo.Ctlcontrols.fastReverse();
                //wmpVideo.settings.rate = -4.0;
            }
        }
        private void last_MouseUp(object sender, MouseEventArgs e)
        {
            //wmpVideo.Ctlcontrols.fastForward();
            wmpVideo.settings.rate = 1;
            kuaituiTimer.Dispose();
        }
        #endregion

        #region 音量大小调节
        //静音
        Boolean muteFlag = false;
        private void volume_Click(object sender, EventArgs e)
        {
            muteFlag = !muteFlag;
            if (muteFlag)
            {
                volume.BackgroundImage = Image.FromFile("../../image/mute-red.png");
                wmpVideo.settings.mute = true;
            }
            else
            {
                volume.BackgroundImage = Image.FromFile("../../image/volume4.png");
                wmpVideo.settings.mute = false;
            }
        }
        //音量大小拖动条
        public Boolean volumeProgressFlag = false;
        public void volumeProcessMove()
        {
            //鼠标相对于屏幕的坐标
            p1 = MousePosition;
            //鼠标相对于窗体的坐标
            p2 = volumeProgressPanel.PointToClient(p1);
            int temp = p2.X * 100 / (volumeProgressPanel.Width - 3);
            temp = temp > 100 ? 100 : temp;
            temp = temp < 0 ? 0 : temp;
            volumeProgressBar.Value = temp;
            wmpVideo.settings.volume = volumeProgressBar.Value;
            p2.X = p2.X > volumeProgressPanel.Width ? volumeProgressPanel.Width - 3 : p2.X;
            p2.X = p2.X < 0 ? 0 : p2.X;
            volumeProgressBarPoint.Location = new Point(p2.X, volumeProgressBarPoint.Location.Y);
            //Console.WriteLine( p2.X+","+volumeProgressBarPoint.Location.Y);
        }
        private void volumeProgressPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (volumeProgressFlag)
            {
                volumeProcessMove();
            }
        }

        private void volumeProgressPanel_MouseDown(object sender, MouseEventArgs e)
        {
            volumeProcessMove();
            volumeProgressFlag = true;
        }

        private void volumeProgressPanel_MouseUp(object sender, MouseEventArgs e)
        {
            volumeProgressFlag = false;
        }
        #endregion

        #region 视屏进度条移动
        public Boolean videoProgressFlag = false;
        public Point p1, p2;
        public void videoProcessMove()
        {
            //鼠标相对于屏幕的坐标
            p1 = MousePosition;
            //鼠标相对于窗体的坐标
            p2 = videoProgressPanel.PointToClient(p1);
            int temp = p2.X * 100 / (videoProgressPanel.Width - 4);
            temp = temp > 100 ? 100 : temp;
            temp = temp < 0 ? 0 : temp;
            if (wmpVideo.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                videoProgressBar.Value = temp;
                wmpVideo.Ctlcontrols.currentPosition = temp * wmpVideo.currentMedia.duration / 100;
                p2.X = p2.X > videoProgressPanel.Width - 4 ? videoProgressPanel.Width - 4 : p2.X;
                p2.X = p2.X < 0 ? 0 : p2.X;
                videoProgressBarPoint.Location = new Point(p2.X, videoProgressBarPoint.Location.Y);
            }
        }
        public void videoProcessMove_valueAndPoint()
        {
            //鼠标相对于屏幕的坐标
            p1 = MousePosition;
            //鼠标相对于窗体的坐标
            p2 = videoProgressPanel.PointToClient(p1);
            int temp = p2.X * 100 / (videoProgressPanel.Width - 4);
            temp = temp > 100 ? 100 : temp;
            temp = temp < 0 ? 0 : temp;
            if (wmpVideo.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                videoProgressBar.Value = temp;
                p2.X = p2.X > videoProgressPanel.Width - 4 ? videoProgressPanel.Width - 4 : p2.X;
                p2.X = p2.X < 0 ? 0 : p2.X;
                videoProgressBarPoint.Location = new Point(p2.X, videoProgressBarPoint.Location.Y);
            }
        }
        private void videoProgressPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (videoProgressFlag)
            {
                videoProcessMove_valueAndPoint();
            }
        }
        private void videoProgressPanel_MouseDown(object sender, MouseEventArgs e)
        {
            videoProcessMove();
            videoProgressFlag = true;
        }
        private void videoProgressPanel_MouseUp(object sender, MouseEventArgs e)
        {
            videoProcessMove();
            videoProgressFlag = false;
        }
        #endregion
        #endregion

        #region 播放进度实时改变
        void PlayRealTimeChange(String filePath)
        {
            wmpVideo.URL = filePath;
            //播放按钮切换
            PlayFlag = true;
            pause.BackgroundImage = Image.FromFile("../../image/pause2.png");
            //底部栏显示视频名字
            if (PLAYFLAG)
            {
                videoTitle.Text = wmpVideo.currentMedia.name;
                HistoryList.Add(filePath);
                //按钮纠正
                PlayButtonCorrect();
            }
        }
        void PlayProgressChange(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (PLAYFLAG)
            {
                double percentage =0;
                //if (wmpVideo.Ctlcontrols.currentPosition!=0&& wmpVideo.currentMedia.duration!=0)
                    percentage = wmpVideo.Ctlcontrols.currentPosition / wmpVideo.currentMedia.duration;
                int temp = (int)(percentage * 100 + 0.5);
                temp = temp > 100 ? 100 : temp;
                temp = temp < 0 ? 0 : temp;
                videoProgressBar.Value = temp;
                videoProgressBarPoint.Location = new Point((int)(percentage * (videoProgressPanel.Width - videoProgressBarPoint.Width)), videoProgressBarPoint.Location.Y);
                //播放时间改变
                CurrentTimeShow.Text = wmpVideo.Ctlcontrols.currentPositionString;
                //播放总时间改变
                //if (wmpVideo.currentMedia.durationString != "")
                    totalTimeShow.Text = wmpVideo.currentMedia.durationString;
            }
        }
        #endregion

        #region 播放列表
        //收藏列表
        public List<string> CollectionList = new List<string>(0);
        //播放历史列表
        public List<string> HistoryList = new List<string>(0);
        //当前文件夹列表
        public List<string> FolderList = new List<string>(0);
        //文件列表
        String fileType = "视频文件(*.avi;*.wmv;*.mp4;*.mkv;*.FLV;.*RMVB)|*.avi;*.wmv;*.mp4;*.mkv;*.FLV;.*RMVB|(All file(*.*)|*.*";
        
        //播放列表显示与隐藏按钮
        private void playList_Click(object sender, EventArgs e)
        {
            if (PLAYLISTFLAG)
            {
                PLAYLISTFLAG = !PLAYLISTFLAG;
                playListShow.Stop();
            }
            else
            {
                PLAYLISTFLAG = !PLAYLISTFLAG;
                playListShow.Start();
            }
                
        }
        public static List<string> GetFolderList(string path)
        {
            string[] playarray = Directory.GetFiles(path);
            var result = from playstring in playarray
                         where playstring.EndsWith("wmv", StringComparison.OrdinalIgnoreCase) ||
                         playstring.EndsWith("avi", StringComparison.OrdinalIgnoreCase) ||
                         playstring.EndsWith("mp4", StringComparison.OrdinalIgnoreCase) ||
                         playstring.EndsWith("mkv", StringComparison.OrdinalIgnoreCase) ||
                         playstring.EndsWith("FLV", StringComparison.OrdinalIgnoreCase) ||
                         playstring.EndsWith("RMVB", StringComparison.OrdinalIgnoreCase)
                         select playstring;
            return result.ToList();
        }
        int ListFlag = 2;
        //添加视频
        private void addToList_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                //文件路径
                string playpath = null;
                //文件目录
                string directory = null;
                fileDialog.Filter = fileType;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    //文件路径
                    playpath = fileDialog.FileName;
                    //文件目录路径
                    directory = Path.GetDirectoryName(playpath);
                    FolderList = GetFolderList(directory);
                    if (!string.IsNullOrWhiteSpace(playpath))
                    {
                        //视频播放
                        //wmpVideo.URL = playpath;
                        PLAYFLAG = true;
                        PlayRealTimeChange(playpath);
                        if (ListFlag == 1)
                        {
                            playListAdd(FolderList);
                        }
                        else if(ListFlag == 2)
                        {
                            playListAdd(HistoryList);
                        }
                        else if(ListFlag == 3)
                        {
                            playListAdd(CollectionList);
                        }
                    }
                }
            }
        }

        #region 播放列表控件增加和删除
        //播放列表控件增加
        void playListAdd(List<String> playList)
        {
            PlayListRemove();
            //文件数
            int playListLength = playList.Count;
            Console.WriteLine("历史纪录数量：" + playListLength);
            for (int i = 0; i < playListLength; i++)
            {
                //获取文件序号
                //在小于10的序号前添个0
                String listNumber;
                listNumber = i + 1 < 10 ? "0" + (i + 1).ToString() : (i + 1).ToString();
                FileInfo fielInfo = new FileInfo(playList[i]);
                //获取文件名称
                String filename = System.IO.Path.GetFileName(playList[i]);
                //获取文件时间
                String fileTime = GetVideoLength.GetMediaTimeLen(playList[i]);
                //设置listelement
                ListElement listElement = new ListElement(listNumber, filename, fileTime, false);
                listElement.Location = new Point(0, i * listElement.Height);
                PlayListPanel.Controls.Add(listElement);
                //wmp内置播放列表
                //wmpVideo.currentPlaylist.appendItem(wmpVideo.newMedia(playList[i]));
            }
        }
        //播放列表控件删除
        public void PlayListRemove()
        {
            PlayListPanel.Controls.Clear();
        }
        #endregion

        #region 播放列表存储和读取
        //存储历史播放列表
        public void SaveHistoryList(Boolean coverFlag)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"F:\Practice\c#\VideoPlay\VideoPlay\bin\Debug\HistoryList.txt", coverFlag))
            {
                foreach (string line in HistoryList)
                {
                    Console.Write(1);
                    file.WriteLine(line);// 直接追加文件末尾，换行   
                }
            }
        }
        //获取历史播放列表
        public void GetHistoryList()
        {
            //从头到尾以流的方式读出文本文件
            //该方法会一行一行读出文本
            if (File.Exists(".\\HistoryList.txt") == false)
            {
            }
            else
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(@".\HistoryList.txt"))
                {
                    string str;
                    while ((str = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                        HistoryList.Add(str);
                    }
                }
            }
        }
        //存储收藏播放列表
        public void SaveCollectionList()     //保存至.lst文件
        {
            //我的收藏
            if (File.Exists(".\\CollectionList") == true)
            {
                File.Delete(".\\CollectionList");
            }
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = "CollectionList";
            sf.RestoreDirectory = true;
            sf.FilterIndex = 1;
            FileStream fs = new FileStream(string.Format("{0}", sf.FileName), FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, CollectionList);     //保存
            fs.Close();
        }
        //获取收藏播放列表
        public void GetCollectionList()
        {
            //我的收藏列表
            if (File.Exists(".\\CollectionList") == false)
            {
            }
            else
            {
                OpenFileDialog of = new OpenFileDialog();
                of.FileName = "CollectionList";
                of.RestoreDirectory = true;
                of.FilterIndex = 1;
                FileStream fs = new FileStream(string.Format("{0}", of.FileName), FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                this.CollectionList = ((List<string>)bf.Deserialize(fs));
                fs.Close();
            }
        }
        #endregion

        private void myCollection_Click(object sender, EventArgs e)
        {
            //GetCollectionList();
            //playListAdd(CollectionList);
        }

        private void historyList_Click(object sender, EventArgs e)
        {
            //GetHistoryList();
            //PlayListRemove();
            //playListAdd(HistoryList);
        }
        //切换到我的电脑
        private void myComputer_Click(object sender, EventArgs e)
        {
        }
        #endregion
    }
}
