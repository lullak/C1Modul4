namespace OOGThinkOO3.Classes
{
    public class Vehicle
    {
        public int VehicleRegNumber { get; set; }
        public int VehicleYear { get; set; }
        public string VehicleColor { get; set; }
        public double Weight { get; set; }

        public Vehicle(int vehicleRegNumber, int vehicleYear, string vehicleColor, double weight)
        {
            VehicleRegNumber = vehicleRegNumber;
            VehicleYear = vehicleYear;
            VehicleColor = vehicleColor;
            Weight = weight;
        }
    }
}
