using System;
/**
 * 利用goto语句实现1+2+3+......+100的求和
 * 定义标签🏷️的使用
 */
namespace goto_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 0;
        loop:   //定义标签
            sum += i;
            i++;
            if (i <= 100) goto loop;
            Console.WriteLine("1+2+3+....+100={0}",sum);
            Console.ReadKey();
        }
    }
}
