using System;
namespace Class_demo_test_chaoxing
{
    public class Ticket
    {
        private double distance;
        
        public double Distance
        {
            get { return distance; }
            set {
                distance = value;  }
        }

        public Ticket()
        {
            
        }
        ~Ticket(){
            Console.WriteLine("Hello World!");
        }

    }
}
