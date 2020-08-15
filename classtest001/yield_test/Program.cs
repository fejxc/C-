using System;
using System.Collections.Generic;
/**
 * 命名空间指的是控制台程序里最大的括号里的，即namespace里，
 * 在这个空间里不能直接包含字段或者方法
 * 解决方法：将这个方法放到类里边
 */
namespace yield_test
{

   
    
    class Program
    {
        static IEnumerable<int> OddNumber(int maxNumber)
        {
            int num = 0;
            while (true)
            {
                num++;
                if (num % 2 == 1)
                    yield return num;
                if (num >= maxNumber)
                    yield break;

            }


        }

        static void Main(string[] args)
        {
            int j = 0;
            Console.WriteLine("你想输出1到多少的奇数？");
            int k = int.Parse(Console.ReadLine());
            foreach(int i in OddNumber(k))
            {
                Console.Write("{0} ", i);
                j++;
                if (j % 5 == 0)
                    Console.WriteLine();
            }
            
            

        }
    }
}
