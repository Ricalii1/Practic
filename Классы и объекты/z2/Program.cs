using System;

namespace z2
{
    class Point
    {
        string name;
        int x;
        int y;
        public int X
        {
            get { return x;}
        }
        public int Y
        {
            get { return y; }
        }
        public string Name
        {
            get { return name; }
        }

        public Point()
        : this("", 0, 0) { }

        public Point(string name, int x, int y)
        {
            Console.WriteLine("Введите название точки: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Введите x ");
            this.x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            this.y = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Figure
    {
        int number;
        Point[] points;
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void InitializeFigure()
        {
            Console.WriteLine("Введите количество вершин: ");
            number = Convert.ToInt32(Console.ReadLine());
            points = new Point[number];

            for (int i = 0; i < number; i++)
                points[i] = new Point();

        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length - 1]);
            return perimeter;
        }
        public Figure(string name)
        {
            InitializeFigure();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure cube = new Figure("Cube");
            Console.WriteLine(cube.CalculatePerimeter());
            Console.ReadKey();
        }
    }
}
