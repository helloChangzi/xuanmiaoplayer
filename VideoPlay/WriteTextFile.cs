using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPlay
{
    class WriteTextFile
    {
        public static void WriteTest()
        {
            //如果文件不存在，则创建；存在则覆盖
            //该方法写入字符数组换行显示
            string[] lines = { "first line", "second line", "third line", "第四行" };
            System.IO.File.WriteAllLines(@"C:\Users\xuanmiao\Desktop\test.txt", lines, Encoding.UTF8);

            //如果文件不存在，则创建；存在则覆盖
            string strTest = "该例子测试一个字符串写入文本文件。";
            System.IO.File.WriteAllText(@"C:\Users\xuanmiao\Desktop\test1.txt", strTest, Encoding.UTF8);

            //在将文本写入文件前，处理文本行
            //StreamWriter一个参数默认覆盖
            //StreamWriter第二个参数为false覆盖现有文件，为true则把文本追加到文件末尾
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\xuanmiao\Desktop\test2.txt", true))
            {
                foreach (string line in lines)
                {
                    if (!line.Contains("second"))
                    {
                        file.Write(line);//直接追加文件末尾，不换行
                        file.WriteLine(line);// 直接追加文件末尾，换行   
                    }
                }
            }
        }
    }
}
