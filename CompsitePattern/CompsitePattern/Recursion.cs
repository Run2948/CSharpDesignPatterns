using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompsitePattern
{
    /// <summary>
    /// 递归
    /// </summary>
    public class Recursion
    {
        /// <summary>
        /// 给一个根目录，获取全部的文件夹
        /// </summary>
        /// <param name="rootPath"></param>
        /// <returns></returns>
        public static List<DirectoryInfo> GetDirectoryList(string rootPath)
        {
            List<DirectoryInfo> dirList = new List<DirectoryInfo>();

            DirectoryInfo dirRoot = new DirectoryInfo(rootPath);//根目录
            dirList.Add(dirRoot);

            GetDirectoryListChild(dirList, dirRoot);

            //DirectoryInfo[] dirList1 = dirRoot.GetDirectories();//一级子目录
            //dirList.AddRange(dirList1);

            //foreach (var dir1 in dirList1)
            //{
            //    DirectoryInfo[] dirList2 = dir1.GetDirectories();//二级子目录
            //    dirList.AddRange(dirList2);

            //    foreach (var dir2 in dirList2)
            //    {
            //        DirectoryInfo[] dirList3 = dir2.GetDirectories();//三级子目录
            //        dirList.AddRange(dirList3);
            //    }
            //}

            return dirList;
        }

        /// <summary>
        /// 找出当前文件夹的子文件夹，放入结果容器
        /// </summary>
        /// <param name="dirList">结果容器</param>
        /// <param name="dirParent">当前文件夹</param>
        private static void GetDirectoryListChild(List<DirectoryInfo> dirList, DirectoryInfo dirParent)
        {
            DirectoryInfo[] dirListChild = dirParent.GetDirectories();//一级子目录
            dirList.AddRange(dirListChild);

            foreach (var dir in dirListChild)
            {
                //DirectoryInfo[] dirListChild1 = dir.GetDirectories();//二级子目录
                //dirList.AddRange(dirListChild1);

                GetDirectoryListChild(dirList, dir);
            }
        }
    }

}
