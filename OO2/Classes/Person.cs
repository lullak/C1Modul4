namespace OO2.Classes
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }

        public virtual string Hello(string text)
        {
            return "Hello " + text;
        }

    }
}
