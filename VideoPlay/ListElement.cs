using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace VideoPlay
{
    public partial class ListElement : UserControl
    {
        Boolean collect =false;
        public ListElement(String number, String name, String time, Boolean collection)
        {
            InitializeComponent();
            this.number.Text = number;
            Console.Write("序号：" + number);
            this.name.Text = name;
            Console.Write("名字：" + name);
            this.time.Text = time;
            Console.Write("时间：" + time);
            var collect = collection;
            Console.WriteLine();
        }

        private void Collection_Click(object sender, EventArgs e)
        {
        }
    }
}
