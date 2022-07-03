using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {

        class Criminal
        {
            public string name;
            public string сrime;

            public Criminal(string name, string сrime)
            {
                this.name = name;
                this.сrime = сrime;
            }
        }

        static void Main(string[] args)
        {
            List<Criminal> Criminals = new List<Criminal>(){
                new Criminal("Ким Тэхен", "Антиправительственное"),
                new Criminal("Мияваки Сакура","Антиправительственное"),
                new Criminal("Киселева Ксения Ринатовна", "Воинское"),
                new Criminal("Мин Юнги", "Антиправительственное"),
                new Criminal("Сенин Иван Владимирович", "Экономическое"),
                new Criminal("Труханова Виктория Александровна","Экономическое"),
             };

            try
            {
                IEnumerable<Criminal> CrimList = from ppl in Criminals
                                                 where
                       ppl.сrime != "Антиправительственное"
                                                 select ppl;

                Console.WriteLine("Список до амнистии: \n");
                foreach (Criminal a in Criminals)
                {
                    Console.WriteLine(a.name + " - " + a.сrime);
                }

                Console.WriteLine("\n\nСписок после амнистии: \n");
                foreach (Criminal a in CrimList)
                {
                    Console.WriteLine(a.name + " - " + a.сrime);
                }

                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
