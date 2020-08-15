using System;

namespace 输入三角形的三条边_输出三角形的面积
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Please input first a :");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input secode b :");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input thrid c:");
            c = double.Parse(Console.ReadLine());

            if (a + b < c || a + c < b || b + c < a)
                Console.WriteLine("data error!");
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("the triangle area is:{0}", s);
            Console.ReadKey();
        }
    }
}

