using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Random r = new Random();

                List<int> list = new List<int>();
                Console.WriteLine("Количество клиентов: ");
                int a = r.Next(1, 5);
                Console.WriteLine(a + " ");
                int[] arr = new int[a];

                int bill = 0; //счет
                Console.WriteLine("Сумма покупок: ");
                for (int i = 0; i < a; i++)
                {
                    arr[i] += r.Next(10, 15);
                    list.Add(arr[i]);
                    Console.Write(list[i] + " ");
                }

                Console.WriteLine("\nОбслужить клиента? 1 - yes, 0 - no");
                int p = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("bill:");
                if (p == 0)
                {
                    Process.GetCurrentProcess().Kill();
                } 
                if (p == 1)
                {
                    foreach (int item in list)
                    {
                        bill += item;
                        for (int i = 0; i < a; i++)
                        {
                            list.Remove(i);
                        }
                        
                    }
                    Console.WriteLine(bill + "");
                    Console.WriteLine("\nСписок:");
                    for (int i = 0; i < a; i++)
                    {
                        Console.Write(list[i] + " ");
                    }
                }
                Console.ReadKey();
            }
            
        }
    }
}
