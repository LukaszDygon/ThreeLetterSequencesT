using System;

namespace ParkingGarage.Models
{
    public class Space : IParkable
    {
        private Vehicle _vehicle;
        private readonly VehicleSize _maxVehicleSize;

        public Space(VehicleSize maxVehicleSize)
        {
            _vehicle = null;
            _maxVehicleSize = maxVehicleSize;
        }

        public void ParkVehicle(Vehicle parkingVehicle)
        {
            if (CanPark(parkingVehicle))
            {
                _vehicle = parkingVehicle;
            }
        }

        public void UnparkVehicle(Vehicle vehicle)
        {
            if (_vehicle != vehicle) throw new Exception("The vehicle is not parked here");
            UnparkVehicle();
        }

        public void UnparkVehicle()
        {
            _vehicle = null;
        }

        public bool IsOccupied()
        {
            return _vehicle != null;
        }

        public bool CanPark(Vehicle vehicleToPark)
        {
            return !IsOccupied() && _maxVehicleSize <= vehicleToPark.GetSize();
        }
    }



}
