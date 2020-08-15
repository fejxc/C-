using System;
using System.Collections.Generic;

namespace fib_test
{
    class Program
    {
        static IEnumerable<int> Fibr(int n)
        {
            int a=0, b=1;
            while (true)
            {
                if (a < n)
                {
                    
                    a = b;
                    b = a + b;
                    yield return a;
                    
                }
                if(a>=n)
                {
                    yield break;
                }
               
            }

            }


        
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你想打印从1到多少的fib数列：");
            int i = int.Parse(Console.ReadLine());
            foreach(int j in Fibr(i))
            Console.WriteLine("{0} ",j);
        }
    }
}
