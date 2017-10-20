using System;

namespace ParkingGarage.Models
{
    public abstract class Vehicle : IComparable
    {
        private readonly VehicleSize _vehicleSize;
        private readonly string _registration;

        protected Vehicle(string registration, VehicleSize vehicleSize)
        {
            _registration = registration;
            _vehicleSize = vehicleSize;
        }

        public string GetRegistration()
        {
            return _registration;
        }

        public VehicleSize GetSize()
        {
            return _vehicleSize;
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Vehicle otherVehicle))
            {
                throw new ArgumentException("The object is not a Vehicle object");
            }
            if (_vehicleSize > otherVehicle._vehicleSize)
            {
                return 1;
            }
            if (_vehicleSize == otherVehicle._vehicleSize)
            {
                return 0;
            }
            return -1;
        }
    }
}
