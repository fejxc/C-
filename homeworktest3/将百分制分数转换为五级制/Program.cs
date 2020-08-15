using System;

namespace 将百分制分数转换为五级制
{
    class Program
    {
        static int i;
        static void Main(string[] args)
        {

            Console.WriteLine("Please input score data:");
            double score = double.Parse(Console.ReadLine());
            if (score >= 90 && score <= 100)
                i = 1;

            if (score >= 80 && score < 90)
                i = 2;
            if (score >= 70 && score < 80)
                i = 3;
            if (score >= 60 && score < 70)
                i = 4;
            if (score >= 0 && score < 60)
                i = 5;

            switch (i)
            {
                case 1:
                    Console.WriteLine("the levle is 优");
                    break;
                case 2:
                    Console.WriteLine("the levle is 良");
                    break;
                case 3:
                    Console.WriteLine("the levle is 中");
                    break;
                case 4:
                    Console.WriteLine("the levle is 及格");
                    break;
                case 5:
                    Console.WriteLine("the levle is 不及格");
                    break;
                default:
                    Console.WriteLine("please input data betweet 1--100");
                    break;

            }
            Console.ReadKey();

        }
    }
}