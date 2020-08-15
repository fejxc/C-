using System;

namespace _02
{
    class Program
    {

        static void Main(string[] args)
        {
            Stock stock = new Stock();
            stock[1] = 12345;
          
                Console.WriteLine("{0}", stock[1]);
            
        }
    }
}
