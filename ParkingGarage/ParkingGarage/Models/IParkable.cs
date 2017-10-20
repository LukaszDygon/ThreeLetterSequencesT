using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage.Models
{
    internal interface IParkable
    {
        void ParkVehicle(Vehicle vehicle);
        void UnparkVehicle(Vehicle vehicle);
    }
}
