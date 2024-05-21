using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    internal class Loan
    {
        public double time;
        public double i;
        public double present_value;
        public float accumulated_value;

        public Loan(double time, double i, double present_value)
        {
            this.time = time;
            this.i = i;
            this.present_value = present_value;


        }

        public float SimpleInterest(double time, double i, double present_value)
        {
            this.time = time;
            this.i = i;
            this.present_value = present_value;


            accumulated_value = Convert.ToSingle(this.present_value * (1 + ((this.i/100) * this.time)));

            return accumulated_value;
        }

        public float CompoundInterest(double time, double i, double present_value)
        {
            this.time = time;
            this.i = i/100;
            this.present_value = present_value;

            accumulated_value = Convert.ToSingle(this.present_value * Math.Pow(1 + (this.i/100), this.time));

            return accumulated_value;
        }
    }
}
