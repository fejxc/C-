using System;
/**
 * 编写控制台应用程序，按照累进税率计算个人所得税(年收入 6 万元以下不纳税;年收入扣除 6 万元后，
 * 不超过 36000 元的部分税率为 3%，超过 36000 元至 144000 元 的部分税率为 10%，超过 144000
 * 元至 300000 元的部分税率为 20%，超过 300000 元至 420000 元的部分税率为 25%，超过 420000
 * 元至 660000 元的部分税率为 30%，超过 660000 元至 960000 元的部分税率为 40%，超过 960000
 * 元的部分税率为 45%)。
 */
namespace 按照累进税率计算个人所得税
{
    class Program
    {
        static void Main(string[] args)
        {
            const int price = 60000;
            Console.WriteLine("请输入你的年收入金额：");
            Double x,y,z;
            x = double.Parse(Console.ReadLine());
            if(x<=price)
            {
                Console.WriteLine("年收入6万元以下不纳税!");
            }
            else if(x>price)
            {
                y = x - price;
                if(y<=36000)
                {
                    z = y * 0.03;

                    Console.WriteLine("税率为3%:{0}", z);
                }
                if(y > 36000&&y<=144000)
                {
                    z = y * 0.1;

                    Console.WriteLine("税率为10%:{0}", z);
                }
                if (y > 144000 && y <= 300000)
                {
                    z = y * 0.2;

                    Console.WriteLine("税率为20%:{0}", z);
                }
                if (y > 300000 && y <= 420000)
                {
                    z = y * 0.25;

                    Console.WriteLine("税率为25%:{0}", z);
                }
                if(y > 420000 && y <= 660000)
                {
                    z = y * 0.3;

                    Console.WriteLine("税率为30%:{0}", z);
                }
                if (y > 660000 && y <= 960000)
                {
                    z = y * 0.4;

                    Console.WriteLine("税率为40%:{0}", z);
                }
                if (y > 960000)
                {
                    z = y * 0.45;

                    Console.WriteLine("税率为45%:{0}", z);
                }


            }
        }
    }
}
