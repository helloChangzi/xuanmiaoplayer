using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPlay
{
    public static class GetVideoLength
    {
        //public static string GetMediaDuration(this string path)
        //{
        //    try
        //    {
        //        Shell32.Shell shell = new Shell32.Shell();
        //        Shell32.Folder folder = shell.NameSpace(path.Substring(0, path.LastIndexOf("\\")));

        //        Shell32.FolderItem folderItem = folder.ParseName(path.Substring(path.LastIndexOf("\\") + 1));

        //        return folder.GetDetailsOf(folderItem, 21);
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}

        public static string GetMediaTimeLen(string path)
        {
            try
            {
                Shell32.Shell shell = new Shell32.Shell();
                //文件路径               
                Shell32.Folder folder = shell.NameSpace(path.Substring(0, path.LastIndexOf("\\")));
                //文件名称             
                Shell32.FolderItem folderitem = folder.ParseName(path.Substring(path.LastIndexOf("\\") + 1));
                if (Environment.OSVersion.Version.Major >= 6)
                {
                    return folder.GetDetailsOf(folderitem, 27);
                }
                else
                {
                    return folder.GetDetailsOf(folderitem, 21);
                }
            }
            catch (Exception ex) { return null; }
        }
        public static String GetMediaTimeLenSecond(string path)
        {
            try
            {
                Shell32.Shell shell = new Shell32.Shell();
                //文件路径               
                Shell32.Folder folder = shell.NameSpace(path.Substring(0, path.LastIndexOf("\\")));
                //文件名称             
                Shell32.FolderItem folderitem = folder.ParseName(path.Substring(path.LastIndexOf("\\") + 1));
                string len;
                if (Environment.OSVersion.Version.Major >= 6)
                {
                    len = folder.GetDetailsOf(folderitem, 27);
                }
                else
                {
                    len = folder.GetDetailsOf(folderitem, 21);
                }
                //string[] str = len.Split(new char[] { ':' });
                //String sum;
                ////sum = int.Parse(str[0]) * 60 * 60 + int.Parse(str[1]) * 60 + int.Parse(str[2]);
                //sum = str[0] + ":" + str[1] + ":" + str[2];
                Console.WriteLine(len);
                return len;
            }

            catch (Exception ex) { return "00:00:00"; }
        }
    }
}
