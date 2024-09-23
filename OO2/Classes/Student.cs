namespace OO2.Classes
{
    sealed class Student : Person
    {
        public bool Enrolled { get; set; }
        public bool HasCSN { get; set; }

        public Student(bool enrolled, bool hasCSN, string firstName, string surname, string city)
        {
            Enrolled = enrolled;
            HasCSN = hasCSN;
            FirstName = firstName;
            Surname = surname;
            City = city;
        }

        public override string Hello(string text)
        {
            return base.Hello(text);
        }
    }
}
