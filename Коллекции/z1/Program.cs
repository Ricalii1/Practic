using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var d = new Dictionary<string, string>();
                d.Add("музыка", "вид искусства, воплощенное через звуки");
                d.Add("волейбол", "командный вид спорта с мячом");
                d.Add("фэнтези", "жанр в литературе");
                d.Add("наследование", "один из принципов ООП");
                d.Add("яблоко", "плод яблони");
                string s;
                while (true)
                {
                    Console.WriteLine("\nВведите слово: ");
                    s = Console.ReadLine().Trim().ToLower();
                    if (d.ContainsKey(s))
                        Console.WriteLine(d[s]);
                    else
                        Console.WriteLine("Слово отсутствует в словаре." + "\n");

                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
