﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class TurboCharger : VehicleDecorator
    {
        private int horsePower = 0;
        private double cost = 0.0;
        private string description = "";
        public Vehicle aVehicle;

        public TurboCharger(Vehicle aCar)
        {
            this.aVehicle = aCar;
            this.horsePower = this.aVehicle.HorsePower+50;
            this.Cost = this.aVehicle.Cost + 400;
            this.Description = this.aVehicle.Description+" with a Tuuuuurbo";
        }
        public override int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            set
            {
                this.horsePower = value;
            }
        }
        public override double Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                this.cost = value;
            }
        }
        public override string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        public override string ToString()
        {
            string message = "";
            message = message + "A $" + this.Cost + " Car \n";
            message = message + "With " + this.HorsePower + " Horse Power \n";
            message = message + this.Description;
            return message;
        }
    }
}
