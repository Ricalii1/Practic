using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    class Program
    {
        class Player
        {
            public string name;
            public int level;
            public int force;


            public Player(string name, int level, int force)
            {
                this.name = name;
                this.level = level;
                this.force = force;
            }
        }
        static void Main(string[] args)
        {
            
             
        List<Player> PlayerList = new List<Player>() {
            new Player("Ким Тэхен", 97, 721),
            new Player("Мияваки Сакура", 61, 401),
            new Player("Киселева Ксения Ринатовна", 32, 273),
            new Player("Мин Юнги", 82, 689),
            new Player("Сенин Иван Владимирович", 18, 189),
            new Player("Труханова Виктория Александровна", 42, 365),
            
            };


            Console.WriteLine("Топ 3 игроков по уровню: ");

            IEnumerable<Player> playerss = from plr in PlayerList
                                          orderby plr.level descending
                                          select plr;
            foreach (Player a in playerss.Take(3))
            {
                Console.WriteLine(a.name + "\t" + a.level + "\t" + a.force);
            }

            Console.WriteLine("\nТоп 3 игроков по силе: ");

            playerss = from plr in PlayerList
                      orderby plr.force descending
                      select plr;

            foreach (Player a in playerss.Take(3))
            {
                Console.WriteLine(a.name + "\t" + a.level + "\t" + a.force);
            }

            Console.ReadLine();
        }
    }
}
