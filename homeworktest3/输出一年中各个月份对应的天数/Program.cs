using System;

namespace 输出一年中各个月份对应的天数
{
    class Program
    {
        static void Main(string[] args)
    {
        int year, month = 1, days = 0;
        Console.Write("enter year: ");
        year = int.Parse(Console.ReadLine());
        Console.Write("enter month: ");
        month = int.Parse(Console.ReadLine());

        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
                goto case 12;
            case 10:
            case 12:
                days = 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                days = 30;
                break;
            case 2:
                if ((year) % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                {
                    days = 29;

                }
                else
                {
                    days = 28;
                }
                break;
            default:
                Console.WriteLine("{0}为无效的月份", year);
                break;


        }
        Console.WriteLine("{0}年{1}月有{2}天。", year, month, days);
        Console.ReadKey();

    }
}
}
