using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberApp
{
    public abstract class RentAbs : IBluePrint
    {
        public abstract decimal tavel_dis();

        public virtual void Print()
        {
            Console.WriteLine("Welcome to Uber.");
        }




        /*
        public decimal bikerent()
        {
            return 50;
        }

        public decimal carrent()
        {
            return 100;
        }
        */
    }
}
