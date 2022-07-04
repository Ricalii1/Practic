using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

namespace z3
{
    class Program
    {
        static string path;
        static void SearchFile(DirectoryInfo drin, string filename)
        {
            FileInfo[] fInfo = drin.GetFiles();
            DirectoryInfo[] dirInfo = drin.GetDirectories();

            foreach (FileInfo info in fInfo)
            {
                if (info.Name == filename)
                {
                    path = info.FullName;
                    Console.WriteLine(path);
                }
            }
            foreach (DirectoryInfo dInfo in dirInfo)
                SearchFile(dInfo, filename);
        }

        static void Main(string[] args)
        {
            string filename = "ss.txt";

            DirectoryInfo dr = new DirectoryInfo(@"C:\testt");
            SearchFile(dr, filename);

            if (path == null) Console.WriteLine("Файл несуществует");

            Console.WriteLine("Посмотреть файл? 1 - yes");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                Process pr = Process.Start("notepad.exe", path);
                pr.WaitForExit();
                pr.Close();
            }
            else Console.WriteLine("error");

            Console.WriteLine("Чтобы сжать файл нажмите 1, чтобы выйти из программы нажмите 0");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                path = path.Replace(filename, "");

                ZipFile.CreateFromDirectory(path, @"C:\testt\ss.zip");
                Console.ReadLine();
            }
            else if (x == 0) Process.GetCurrentProcess().Kill();
        }
    }
}
