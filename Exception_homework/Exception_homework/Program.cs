using System;

namespace Exception_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入三角形的第一条边长（整数）:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("请输入三角形的第二条边长（整数）:");
            int y = int.Parse(Console.ReadLine());
            Console.Write("请输入三角形的第三条边长（整数）:");
            int z = int.Parse(Console.ReadLine());
            Triangle tri = new Triangle();
            try
            {
                tri.getTriangle(x, y, z);

            }
            catch (IllegalTriangleException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
