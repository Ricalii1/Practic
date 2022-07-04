using System;

namespace z3
{
    class Program
    {
        Random r = new Random();

        int[] array = new int[10];

        public void GenerateArray()
        {
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 15);
                Console.Write(array[i] + " ");
            }
        }
        public void Print()
        {
            Console.WriteLine("\nПолученный массив: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }

        public void Sort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int x = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = x;
                    }
                }
            }
        }

        static void Main()
        {
            Program p = new Program();

            p.GenerateArray();
            p.Sort();
            p.Print();
            Console.ReadKey();
        }
    }
}
