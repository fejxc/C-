using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("请输入被除数：");
                int x = Int32.Parse(Console.ReadLine());
                Console.Write("请输入除数：");
                int y = Int32.Parse(Console.ReadLine());
                int result = x / y;
                Console.WriteLine("{0}/{1}={2}", x, y, result);
            }
            catch(FormatException)
            {
                Console.Write("输入格式不正确！");
            }
            catch(DivideByZeroException)
            {
                Console.Write("除数不能为0！");
            }
        }
    }
}
