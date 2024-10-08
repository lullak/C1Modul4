namespace OO3.Classes
{
    public class PermanenPosition : Position
    {
        public bool ProfitSharing { get; set; }
        public double Salary { get; set; }

        public PermanenPosition(bool profitSharing, double salary, DateTime endDate, DateTime startDate, string id, Person personPosition) :base(endDate, startDate, id, personPosition)
        {
            ProfitSharing = profitSharing;
            Salary = salary;
        }

        public override double CalculatePay(DateTime start, DateTime end)
        {
            if (ProfitSharing)
                return (end - start).TotalDays / 30 * Salary * 1.05;
            else 
                return (end - start).TotalDays / 30 * Salary;
        }
    }
}
