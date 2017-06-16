using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoPlay
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();//此行为允许虚拟模式运行的命令
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VideoPlayer());
        }
    }
}
