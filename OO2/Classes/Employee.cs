using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OO2.Classes
{
    sealed class Employee : Person
    {
        public int Salary { get; set; }
        public string Role { get; set; }
        public string FormOfEmplyment { get; set; }

        public Employee(int salary, string role, string formOfEmplyment, string firstName, string surname, string city)
        {
            Salary = salary;
            Role = role;
            FormOfEmplyment = formOfEmplyment;
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
