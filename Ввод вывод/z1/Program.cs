using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace z1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
                Directory.CreateDirectory($@"C:\\Folder_{i}");
            Console.WriteLine("Директории созданы");

            Console.WriteLine("Удалить директории?\ny - Да\tn - Нет");
            string s = Console.ReadLine();

            if (s == "y")
            {
                for (int i = 0; i < 5; i++)
                {
                    Directory.Delete($@"C:\\Folder_{i}");
                }
                Console.WriteLine("Директории удалены");
            }
            else if (s == "n")
                Console.WriteLine("Директории в месте создания");
        }
    }
}
