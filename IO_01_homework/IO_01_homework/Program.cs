using System;
using System.IO;
namespace IO_01_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"desktop";
            DirectoryInfo di = new DirectoryInfo(path);
            string[] sdirs = Directory.GetDirectories(path);//获取子目录
            foreach (string sdir in sdirs )
            {
                Console.WriteLine("{0}", sdir);
            }
            string[] fs = Directory.GetFiles(path);
            foreach(string f in fs)
            {
                Console.WriteLine("{0}", f);
            }
            string[] fspdf = Directory.GetFiles(path, "*.pdf");
            foreach (string f in fspdf )
            {
                Console.WriteLine("{0}", f);
            }
        }
    }
}
