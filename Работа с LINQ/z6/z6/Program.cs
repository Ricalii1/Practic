using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z6
{
    class Program
    {
        class Soldier
        {
            public string name;
            public string squad;
            public string rank;
            public int time;

            public Soldier(string n, string a, string r, int t)
            {
                name = n;
                squad = a;
                rank = r;
                time = t;
            }
        }
        static void Main(string[] args)
        {
            List<Soldier> SoldierList = new List<Soldier>()   {

                new Soldier("Ким Тэхен", "Стрелковое", "Генерал армии", 36),
                new Soldier("Мияваки Сакура","Стрелковое", "Лейтенант", 24),
                new Soldier("Киселева Ксения Ринатовна", "Воинское", "Полковник",24),
                new Soldier("Мин Юнги", "Антиправительственное", "Полковник",24),
                new Soldier("Сенин Иван Владимирович", "Экономическое", "Рядовой",18),
                new Soldier("Труханова Виктория Александровна","Экономическое", "Сержант",12)
            };


            IEnumerable<string> SoldQuery = from soldier in SoldierList
                                            select soldier.name + " - " + soldier.rank;

            foreach (string a in SoldQuery)
            {
                Console.WriteLine(a);
            }
            Console.Read();
        }
    }
}
