using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberApp
{
    public class Car : RentAbs
    {
        private string vehicle = "Car";
        readonly decimal init = 100;
        readonly decimal travel_distance = 0;
        private readonly decimal vat = 20;


        public void Display()
        {
            //TODO
        }



        /*
        public Car(decimal initial_cost)
        {
            this.init = initial_cost;
        }

        public decimal carrent()
        {
            return this.init + vat;
        }
        */

        public Car()
        {
            Console.WriteLine($"Welcome to Uber {vehicle} Service.");
        }


        public Car(decimal trav_dis)
        {
            //this.init = initial_cost;
            this.travel_distance = trav_dis;
        }

        public override decimal tavel_dis()
        {
            decimal travel_cost = this.travel_distance * 10;
            decimal total_cost = travel_cost + this.init + vat;
            return total_cost;
        }


        public override void Print()
        {
            Console.WriteLine($"Welcome to Uber {vehicle} Service.");
        }
    }
}
