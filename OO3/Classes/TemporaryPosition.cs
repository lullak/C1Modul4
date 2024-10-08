namespace OO3.Classes
{
    public class TemporaryPosition : Position
    {
        public int MaxAllowedHours { get; set; }
        public double RatePerHour { get; set; }

        public TemporaryPosition(int maxAllowedHours, double ratePerHour, DateTime endDate, DateTime startDate, string id, Person personPosition) : base(endDate, startDate, id, personPosition)
        {
            MaxAllowedHours = maxAllowedHours;
            RatePerHour = ratePerHour;
        }

        public override double CalculatePay(DateTime start, DateTime end)
        {
            double hours = (end - start).TotalHours;
            if (hours > MaxAllowedHours)
                hours = MaxAllowedHours;
            return hours * RatePerHour;
        }
    }
}
