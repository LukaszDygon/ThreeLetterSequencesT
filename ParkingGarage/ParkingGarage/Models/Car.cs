﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage.Models
{
    class Car : Vehicle
    {
        public Car(string registration) : base(registration, VehicleSize.Car)
        {
        }
    }
}
