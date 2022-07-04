using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    public struct Train
    {
        string Name;
        public int Number;
        public DateTime Time;

        public Train(string name, int number, DateTime time)
        {
            this.Name = name;
            this.Number = number;
            this.Time = time;
        }
        
        public void Description()
        {
            Console.WriteLine("Название: " + this.Name + "\n Номер поезда: " + this.Number + "\n Время отправления: " + this.Time);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trn = new Train[2];

            for (int i = 0; i < trn.Length; i++)
            {
                Console.WriteLine("Введите название поезда: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите номер поезда: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите время отправления (в формате чч:мм) : ");
                DateTime time = DateTime.Parse(Console.ReadLine());

                trn[i] = new Train(name, number, time);
            }

            Train sort;
            for (int i = 0; i < trn.Length - 1; i++)
            {
                for (int j = i + 1; j < trn.Length; j++)
                {
                    if (trn[i].Number > trn[j].Number)
                    {
                        sort = trn[i];
                        trn[i] = trn[j];
                        trn[j] = sort;
                    }
                }
            }
            for (int i = 0; i < trn.Length; i++)
            {
                trn[i].Description();
                Console.WriteLine();
            }

            Console.WriteLine("Введите номер поезда для поиска: ");
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < trn.Length; i++)
            {
                if (trn[i].Number == input)
                    trn[i].Description();
                else
                    Console.WriteLine("Поезд не найден");
            }
            Console.ReadKey();
        }
    }
}
