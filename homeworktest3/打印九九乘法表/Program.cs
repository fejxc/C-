using System;

namespace 打印九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 9; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0}x{1}={2} ", j, i, j * i);
                }
                
                Console.WriteLine();
            }
            
          
        }
    }
}
