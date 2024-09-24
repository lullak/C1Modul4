namespace WinFormsLinqDemo2
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthYear { get; set; }
        public int ShoeSize { get; set; }

        public Person(string name, DateTime birthYear, int shoeSize)
        {
            Name = name;
            BirthYear = birthYear;
            ShoeSize = shoeSize;
        }
    }
}
