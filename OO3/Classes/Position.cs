namespace OO3.Classes
{
    public abstract class Position
    {
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public string Id { get; set; }
        public Person PersonPosition { get; set; }
        public abstract double CalculatePay(DateTime start, DateTime end);

        protected Position(DateTime endDate, DateTime startDate, string id, Person personPosition)
        {
            EndDate = endDate;
            StartDate = startDate;
            Id = id;
            PersonPosition = personPosition;
        }
    }
}
