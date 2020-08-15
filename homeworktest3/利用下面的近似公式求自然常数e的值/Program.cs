using System;
/**
 * 
利用下面的近似公式求自然常数e的值，直到最后一项的绝对值小于10-6为止。


 */
namespace 利用下面的近似公式求自然常数e的值
{
    class Program
    {
        public static double fact(int n)
        {
            double f = 1;
            for (int i = 2; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }

        public static double eval(double eps)
        {
            /*double e = 1;

            for(int i = 1; i <= eps; i++)
            {
                e = e + 1 / fact(i);
            }
            return e;*/
            double e = 1;
            int i = 1;
            do
            {
                e = e + 1 / fact(i);
                i++;
            } while (i <= eps);
            return e;
        }
        static void Main(string[] args)
        {
            double sum;

            Console.WriteLine("Input a very small value for Espsilon:");
            sum = double.Parse(Console.ReadLine());
            Console.WriteLine("e={0}", eval(sum));
            Console.ReadKey();
        }
    }
}