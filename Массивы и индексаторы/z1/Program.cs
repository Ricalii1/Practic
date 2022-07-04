using System;

namespace z1
{
    class MyMatrix
    {
        Random r = new Random();
        //private int a, b, c, d;
        public int[,] array = new int[100, 100];

        public MyMatrix(int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    array[i, j] = r.Next(-100, 100);
                }
            }
        }

        public void OutputOfMatrix(int c, int d)
        {
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
    class Matrix2
    {
        private int x, y;
        private int[,] arr = new int[300, 300];

        public Matrix2(ref int[,] matr, int a, int b)
        {
            x = a; y = b;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] = matr[i, j];
                }
            }
        }
        public void OutputOfMatrix2()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            int a, b, c, d;
            Console.WriteLine("Матрица:");
            Console.Write("Введите количество строк: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            b = Convert.ToInt32(Console.ReadLine());

            MyMatrix array1 = new MyMatrix(a, b);
            array1.OutputOfMatrix(a, b);

            Console.WriteLine("Подматрица:");
            Console.Write("Введите количество строк подматрицы: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов подматрицы: ");
            d = Convert.ToInt32(Console.ReadLine());

            Matrix2 m2 = new Matrix2(ref array1.array, c, d);
            m2.OutputOfMatrix2();

            Console.ReadKey();
        }
    }
}
