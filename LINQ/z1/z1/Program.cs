using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        class Criminal
        {
            public string name;
            public bool jail;
            public int height;
            public int weight;
            public string nationality;

            public Criminal(string name, bool jail, int height, int weight, string nationality)
            {
                this.name = name;
                this.jail = jail;
                this.height = height;
                this.weight = weight;
                this.nationality = nationality;
            }
        }


        static void Main(string[] args)
        {
            while (true)
            {
                List<Criminal> Criminals = new List<Criminal>()
                    {
                    new Criminal("Ким Тэхен", false, 180, 69, "кореец"),
                    new Criminal("Мияваки Сакура", false, 161, 47, "кореянка"),
                    new Criminal("Киселева Ксения Ринатовна", true, 178, 51, "русская"),
                    new Criminal("Мин Юнги", false, 173, 59, "кореец"),
                    new Criminal("Сенин Иван Владимирович", true, 180, 74, "русский"),
                    new Criminal("Труханова Виктория Александровна", false, 161, 75, "русская"),
                    };

                try
                {
                    Console.WriteLine("Введите данные преступника для запроса: ");
                    Console.WriteLine("\nРост преступника: ");
                    int CrimHeight = Convert.ToInt32(Console.ReadLine().Trim());
                    Console.WriteLine("\nВес преступника: ");
                    int CrimWeight = Convert.ToInt32(Console.ReadLine().Trim());
                    Console.WriteLine("\nНациональность преступника: ");
                    string CrimNationality = Console.ReadLine().Trim();

                    IEnumerable<Criminal> CriminalsQuery = from CriminalPpl in Criminals where
                                                           CriminalPpl.height == CrimHeight &&
                                                           CriminalPpl.weight == CrimWeight &&
                                                           CriminalPpl.nationality == CrimNationality &&
                                                           CriminalPpl.jail == false
                                                           select CriminalPpl;


                    bool check = true;
                    foreach (Criminal a in CriminalsQuery)
                    {
                        Console.WriteLine("\nПреступник: " + a.name);
                        Console.WriteLine("\nЧтобы продолжить поиск нажмите Enter");
                        check = false;
                    }
                    if (check)
                        Console.WriteLine("\nПреступник не найден!");
                    Console.ReadLine();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }
                
            }

        }
    }
}
