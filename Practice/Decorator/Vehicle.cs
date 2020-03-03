using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public abstract class Vehicle
    {
        private int horsePower = 0;
        private double cost = 0.0;
        private string description = "";

        public virtual int HorsePower { get; set;}
        public virtual double Cost { get; set; }
        public virtual string Description { get; set; }
    }
}
