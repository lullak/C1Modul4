namespace OO3.Classes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ReferenceNumber { get; set; }

        public Person(string firstName, string lastName, string referenceNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            ReferenceNumber = referenceNumber;
        }
    }
}
