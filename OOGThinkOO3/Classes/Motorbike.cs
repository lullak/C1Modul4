namespace OOGThinkOO3.Classes
{
    public class Motorbike:Vehicle
    {
        public int MotorbikeMotorCC { get; set; }

        public Motorbike(int vehicleRegNumber, int vehicleYear, string vehicleColor, double weight, int motorbikeMotorCC):base ()
        {
            MotorbikeMotorCC = motorbikeMotorCC;
        }
    }
}
