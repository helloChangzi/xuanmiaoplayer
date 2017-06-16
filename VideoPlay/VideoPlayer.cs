using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
            this.FormBorderStyle = FormBorderStyle.None;


        }


        // 为了是主界面能够移动
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

        //标题栏移入显示
        private void VideoPlayer_Load(object sender, EventArgs e)
        {
            titlePanel.Visible = false;
            System.Timers.Timer titleShow;
            titleShow = new System.Timers.Timer(100);//定时周期0.1秒
            titleShow.Elapsed += titleBarInJudge;//到1秒了做的事件
            titleShow.AutoReset = true; //是否不断重复定时器操作
            titleShow.Enabled = true;

            // Display the ProgressBar control.
            volumeProgress.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            volumeProgress.Minimum = 0;
            // Set Maximum to the total number of files to copy.
            volumeProgress.Maximum = 98;
            // Set the initial value of the ProgressBar
            volumeProgress.Value = 50;


            // Set the Step property to a value of 1 to represent each file being copied.
            volumeProgress.Step = 1;
        }
        void titleBarInJudge(object sender, System.Timers.ElapsedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            //鼠标相对于屏幕的坐标
            Point p1 = MousePosition;
            //鼠标相对于窗体的坐标
            Point p2 = this.PointToClient(p1);
            int x = p2.X;
            int y = p2.Y;
            if (x < titlePanel.Width && y < titlePanel.Height)
            {
                titlePanel.Visible = true;
            }
            else
            {
                titlePanel.Visible = false;
            }
        }
        //标题栏关闭按钮
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //标题栏最大化按钮
        private void maxBtn_Click(object sender, EventArgs e)
        {
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
        //播放控制栏
        //暂停开始按钮
        private Boolean flag = false;
        public bool Flag { get => flag; set => flag = value; }
        private void pause_Click(object sender, EventArgs e)
        {
            //播放按钮切换
            Flag = !Flag;
            if (Flag)
            {
                pause.BackgroundImage = Image.FromFile("../../image/pause2.png");
            }
            else
            {
                pause.BackgroundImage = Image.FromFile("../../image/play2.png");
            }
            if ((int)wmpVideo.playState == 2)//是否暂停
                wmpVideo.Ctlcontrols.play();
            else if ((int)wmpVideo.playState == 3)//是否播放
                wmpVideo.Ctlcontrols.pause();
            else
            {
                System.Console.WriteLine(wmpVideo.playState);
                wmpVideo.Ctlcontrols.pause();
            }

        }

        string playpath = null;
        string directory = null;
        List<string> playArray = null;
        public static List<string> GetplayCollection(string path)
        {
            string[] playarray = Directory.GetFiles(path);
            var result = from playstring in playarray
                         where playstring.EndsWith("wmv", StringComparison.OrdinalIgnoreCase) ||
                         playstring.EndsWith("avi", StringComparison.OrdinalIgnoreCase)
                         select playstring;
            return result.ToList();
        }
        private void playList_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "视频文件(*.avi;*.wmv;*.mp4;*.mkv;*.FLV;.*RMVB)|*.avi;*.wmv;*.mp4;*.mkv;*.FLV;.*RMVB|(All file(*.*)|*.*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    //wmpVideo.SizeMode = PictureBoxSizeMode.Zoom;
                    playpath = fileDialog.FileName;
                    // 初始化视频集合
                    directory = Path.GetDirectoryName(playpath);
                    playArray = VideoPlayer.GetplayCollection(directory);
                    Flag = !Flag;
                    pause.BackgroundImage = Image.FromFile("../../image/pause2.png");
                }
            }
            wmpVideo.URL = playpath;
        }
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
        
        private DateTime mouseClickTime;


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
        private void next_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClickTime = DateTime.Now;
            kuaijinTimer = new System.Timers.Timer(50);//定时周期0.1秒
            kuaijinTimer.Elapsed += kuaijin;//到1秒了做的事件
            kuaijinTimer.AutoReset = true; //是否不断重复定时器操作
            kuaijinTimer.Enabled = true;
        }
        //按下鼠标超过0.1秒就快进
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
            kuaijinTimer.Dispose();
        }
        #endregion

        #region 快退
        System.Timers.Timer kuaituiTimer;
        //按下鼠标超过0.2秒就快退
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
                wmpVideo.settings.rate = -4.0;
            }
        }
        private void last_MouseUp(object sender, MouseEventArgs e)
        {
            //wmpVideo.Ctlcontrols.fastForward();
            wmpVideo.settings.rate = 1;
            kuaituiTimer.Dispose();
        }
        #endregion
        #region 音量改变
        private Point mouseDownPosition= new Point(557,345);

        System.Timers.Timer volumeChange1;//定时周期0.01秒
        private void volumeProgress_MouseDown(object sender, MouseEventArgs e)
        {
            volumeChange1 = new System.Timers.Timer(10);
            CheckForIllegalCrossThreadCalls = false;
            volumeChange1.AutoReset = true; //是否不断重复定时器操作
            volumeChange1.Enabled = true;
            //距离窗口右侧和底部的最大距离123，15和最小距离41，12
            Console.WriteLine(this.ClientRectangle.Width - 123+","+this.ClientRectangle.Height);
            volumeChange1.Elapsed += volumeDrag;//到1秒了做的事件
        }
        public static Object obj = new object();
        void volumeDrag(object sender, System.Timers.ElapsedEventArgs e)
        {
                //鼠标相对于屏幕的坐标
                Point p12 = MousePosition;
                //鼠标相对于窗体的坐标
                Point p22 = this.PointToClient(p12);
                int x = p22.X;
                //距离窗口右侧和底部的最大距离123，15和最小距离41，12
                if ((x > this.ClientRectangle.Width - 123) && (x < this.ClientRectangle.Width - 41))
                {
                    double changeX = 0;
                    changeX = p22.X - mouseDownPosition.X;
                    Console.WriteLine("mouseDownPosition.X           " + mouseDownPosition.X);
                    Console.WriteLine("p22.X           " + p22.X);
                    Console.WriteLine("changeX           " + changeX);
                    mouseDownPosition = p22;
                    double temp = volumeProgress.Value;
                    temp += changeX * 98 / 82;
                    System.Console.WriteLine("temp       {0}", temp);
                    if (temp > 98)
                        temp = 98;
                    if (temp < 0)
                        temp = 0;
                    volumeProgress.Value = Convert.ToInt32(temp);
                wmpVideo.settings.volume = volumeProgress.Value;
                try
                {
                    progressBarPoint.Location = new Point(( 517 + volumeProgress.Value * 80 / 100), 43);
                    Console.WriteLine(progressBarPoint.Location.X + progressBarPoint.Location.Y);
                }
                catch { }
            }
        }

        private void volume_Click(object sender, EventArgs e)
        {
                
                if (wmpVideo.settings.mute)
                    wmpVideo.settings.mute = !wmpVideo.settings.mute;
                else
                    wmpVideo.settings.mute = !wmpVideo.settings.mute;
        }
        #endregion

        private void volumeProgress_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                volumeChange1.Dispose();
            }catch {}
        }

        private void volumeProgress_Click(object sender, EventArgs e)
        {
            Point p23 = this.PointToClient(MousePosition);
            int x = p23.X;
            int y = p23.Y;
            Console.WriteLine(this.ClientRectangle.Width - 123 + "," + this.ClientRectangle.Height);
            if ((x > this.ClientRectangle.Width - 123 && y > this.ClientRectangle.Height - 15) && (x < this.ClientRectangle.Width - 41 && y < this.ClientRectangle.Height - 12))
            {
                double changeX = 0;
                changeX = p23.X - 517;
                Console.WriteLine("p23.X           " + p23.X);
                System.Console.WriteLine("1changeX           " + changeX);
                double temp = 0;
                if (changeX == 0)
                {
                    temp = 0;
                }
                else
                {
                    temp += changeX * 100 / 82;
                }
                System.Console.WriteLine("1temp       {0}", temp);
                if (temp > 98)
                    temp = 98;
                if (temp < 0)
                    temp = 0;
                volumeProgress.Value = Convert.ToInt32(temp);
                wmpVideo.settings.volume = volumeProgress.Value;
                progressBarPoint.Location = new Point(517 + volumeProgress.Value * 80 / 100, 43);

            }
        }
    }
}
