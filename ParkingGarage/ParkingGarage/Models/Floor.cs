using System;
using System.Collections.Generic;

namespace ParkingGarage.Models
{
    public class Floor : IParkable
    {
        private readonly List<Space> _spaces;

        public Floor(List<Space> spaces)
        {
            _spaces = spaces;
        }

        public void ParkVehicle(Vehicle vehicle)
        {
            if (!CanPark(vehicle)) return;
            var freeSpace = GetFreeSpace(vehicle);

            if (freeSpace == null)
            {
                throw new Exception("Can't park when no spaces are available");
            }
            freeSpace.ParkVehicle(vehicle);
        }

        public void UnparkVehicle(Vehicle vehicle)
        {
            foreach (var space in _spaces)
            {
                try
                {
                    space.UnparkVehicle(vehicle);
                    return;
                }
                catch
                {
                    // ignored
                }
            }
            throw new Exception("The vehicle is not parked on this floor.");
        }

        public bool CanPark(Vehicle vehicle)
        {
            return GetFreeSpace(vehicle) != null;
        }

        private Space GetFreeSpace(Vehicle vehicle)
        {
            return _spaces.Find(space => space.CanPark(vehicle));
        }
    }
}
