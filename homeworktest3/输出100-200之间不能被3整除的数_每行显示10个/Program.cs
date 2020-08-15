using System;

namespace 输出100_200之间不能被3整除的数_每行显示10个
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 100; i <= 200; i++)
            {
                
                if (i % 3 != 0)
                {   
                    Console.Write("{0} ",i);
                    count++;
                    if (count==10)
                    {
                        Console.WriteLine();
                        count = 0;//不能忘记了
                    }

                }
                

            }
            
        }
    }
}
