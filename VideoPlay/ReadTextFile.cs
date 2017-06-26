using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPlay
{
    class ReadTextFile
    {
        public static void ReadTest()
        {
            //直接读取出字符串
            string text = System.IO.File.ReadAllText(@"C:\Users\xuanmiao\Desktop\test1.txt");
            Console.WriteLine(text);

            //按行读取为字符串数组
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\xuanmiao\Desktop\test.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            //从头到尾以流的方式读出文本文件
            //该方法会一行一行读出文本
            using (System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\Users\xuanmiao\Desktop\test.txt"))
            {
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
            Console.Read();
        }
    }
}
