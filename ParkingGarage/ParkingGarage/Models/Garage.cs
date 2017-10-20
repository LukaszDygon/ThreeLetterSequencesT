using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingGarage.Models
{
    public class Garage : IParkable
    {
        private readonly List<Floor> _floors;

        public Garage(IEnumerable<Floor> floors)
        {
            _floors = floors.ToList();
        }

        public IEnumerable<Floor> GetAvailableFloors()
        {
            return _floors;
        }

        public void ParkVehicle(Vehicle vehicle)
        {
            foreach (var floor in _floors)
            {
                try
                {
                    ParkVehicle(vehicle, floor);
                    return;
                }
                catch
                {
                    // ignored
                }
            }
            throw new Exception("Can't park the vehicle");
        }

        public void ParkVehicle(Vehicle vehicle, Floor floor)
        {
            if (!_floors.Contains(floor)) throw new ArgumentException("Floor is not in the garage");
            if (!floor.CanPark(vehicle)) throw new Exception("Can't park the vehicle");
            floor.ParkVehicle(vehicle);
        }

        public void UnparkVehicle(Vehicle vehicle)
        {
            foreach (var floor in _floors)
            {
                try
                {
                    floor.UnparkVehicle(vehicle);
                    return;
                }
                catch
                {
                }
            }
            throw new Exception("The vehicle is not parked in the garage");
        }
    }
}
