using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsLinqDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LINQDates();
        }

        private void LINQDates()
        {
            var dateList = new List<DateTime>();
            List<DateTime> dateList2 = new();

            for (int i = 1; i < 21; i++)
            {
                dateList.Add(DateTime.Now.AddDays(i));
            }

            //Urval från datumlistan som tar alla datum mellan 26 och 29/9

            var result = (from date in dateList
                         where date.Date > DateTime.Parse("2024-09-26") &&
                               date.Date < DateTime.Parse("2024-09-29")
                         orderby date.Date descending
                         select date).ToList();

            DateTime onlyOneDate = (from date in dateList
                                    where date.Date== DateTime.Parse("2024-09-26")
                                    select date).SingleOrDefault();
        }

        private void LINQObjects()
        {
            var personList = new List<Person>()
            {
                new Person("Kalle",DateTime.Parse("1992-02-10"), 42),
                new Person("Lisa",DateTime.Parse("1998-05-12"), 43),
                new Person("Anna",DateTime.Parse("1988-10-12"), 36),
                new Person("Kajsa",DateTime.Parse("1996-06-08"), 45)
            };

            var result = (from person in personList
                          where person.Name.Contains("a")&&
                                person.BirthYear.Year >= 1992 &&
                                person.ShoeSize > 40
                          orderby person.BirthYear.Year, person.Name ascending
                          select person).ToList();


        }
    }
}
