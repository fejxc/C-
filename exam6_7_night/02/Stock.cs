using System;
namespace _02
{
    public class Stock
    {
        private string symbol;
        private int[] price;
        public int this[int index]
        {
            get
            {
                return price[index-1];
            }
            set
            {
                price[index-1] = value;
            }
        }
        public string Symbol
        {
            get
            {
                return symbol;
            }
            set
            {
                try { 
                    int x = int.Parse(symbol);
                }
                catch(FormatException)
                {
                    Console.Write("股票代码不是由数字组成！");
                }
                if (symbol.Length!= 5)
                {
                    throw new Exception("股票代码必须又五位数字构成！");
                }
                symbol = value;
            }

        }
        public string Name 
        {
            get;set;
        }

        public Stock()
        {
        }
        public Stock(string s,string n)
        {
            symbol = s;
            name = n;
         }

    }
}
