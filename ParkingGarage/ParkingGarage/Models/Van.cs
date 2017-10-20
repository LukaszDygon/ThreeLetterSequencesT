namespace ParkingGarage.Models
{
    class Van : Vehicle
    {
        public Van(string registration) : base(registration, VehicleSize.Van)
        {
        }
    }
}
