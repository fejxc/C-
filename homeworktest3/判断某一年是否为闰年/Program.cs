using System;

namespace 判断某一年是否为闰年
{
    class Program
    {
        static void Main(string[] args)
        {   
            int year;
            while (true) { 
            Console.WriteLine("请输入年份：");
            year = int.Parse(Console.ReadLine());
            if ((year) % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("{0}是闰年，2月🈶️29天！",year);

            }
            else
            {
                Console.WriteLine("{0}不是闰年，2月🈶️28天！", year);
            }
            }
        }
    }
}
