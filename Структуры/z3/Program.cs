using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    public static class ColorType
    {
        enum Colors
        {
            Red = 1,
            Green = 2,
            Violet = 3,
            White = 4,
            Blue = 5,
            Gold = 6,
            Yellow = 7
        }
        public static void Print (string stroka, int color)
        {
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ваш цвет - " + Colors.Red + " Ваша строка - " + stroka);
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ваш цвет - " + Colors.Green + " Ваша строка - " + stroka);
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Ваш цвет - " + Colors.Violet + " Ваша строка - " + stroka);
                    Console.ResetColor();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Ваш цвет - " + Colors.White + " Ваша строка - " + stroka);
                    Console.ResetColor();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Ваш цвет - " + Colors.Blue + " Ваша строка - " + stroka);
                    Console.ResetColor();
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Ваш цвет - " + Colors.Gold + " Ваша строка - " + stroka);
                    Console.ResetColor();
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ваш цвет - " + Colors.Yellow + " Ваша строка - " + stroka);
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("Вы не выбрали цвет");
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру от 1 до 7 для выбора цвета: ");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строку: ");
            string s = Console.ReadLine();

            ColorType.Print(s, col);
            Console.ReadKey();
        }
    }
}
