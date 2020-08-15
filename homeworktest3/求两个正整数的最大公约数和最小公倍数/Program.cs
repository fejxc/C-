using System;

namespace 求两个正整数的最大公约数和最小公倍数
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, min;
            Console.WriteLine("求两个正整数的最大公约数和最小公倍数：");
            Console.WriteLine("请输入第一个正数：");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个正数：");
            int n = int.Parse(Console.ReadLine());
            
            if (m > n)
            {
                max = m;
                min = n;
            }
            else
            {
                max = n;
                min = m;
            }
            while (true)
            {
            if (max % m == 0 && max % n == 0)
            {
                Console.WriteLine("{0}为最小公倍数。",max);
                    break;
            }
                max++;
            }
            while (true)
            {
                if (n % min == 0 && m % min == 0)
                {
                    Console.WriteLine("{0}为最大公约数。", min);
                    break;
                }
                min--;
            }
            Console.ReadKey();
        }
    }
}
