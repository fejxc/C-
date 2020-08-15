using System;

namespace 判断一个正整数是否为素数
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int n;
            int i;
            while(true) { 
            Console.WriteLine("请输入一个正整数:");
            n = int.Parse(Console.ReadLine());

            for ( i = 2; i <= Math.Sqrt(n); i++)

                if (n % i == 0)
                    break;
                if(i> Math.Sqrt(n))
                    Console.WriteLine("{0}是素数", n);
                    
                else
                
                    Console.WriteLine("{0}不是素数", n);*/

            int n,i;
            int flag = 0;
            while(true)
            {
                Console.WriteLine("请输入一个正整数:");
                n = int.Parse(Console.ReadLine());
                for(i=2;i<n;i++)
                {
                    if (n % i == 0)
                    {
                        flag++;
                    }
                        
                }
                if(flag==0)
                    Console.WriteLine("{0}是素数", n);
                else
                    Console.WriteLine("{0}不是素数", n);

            }



            }


        }
    
    }
    

