using OO3.Classes;

namespace OO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("a", "a", "a");
            Person b = new Person("b", "b", "b");

            PermanenPosition a1 = new PermanenPosition(true, 30000, DateTime.Parse("2024-12-31"), DateTime.Parse("2024-01-01"), "1", a);
            TemporaryPosition b1 = new TemporaryPosition(70, 200, DateTime.Parse("2024-12-31"), DateTime.Parse("2024-01-01"), "2", b);

            Console.WriteLine(a1.CalculatePay(DateTime.Parse("2024-01-01"), DateTime.Parse("2024-12-31")));
            Console.WriteLine(b1.CalculatePay(DateTime.Parse("2024-01-01"), DateTime.Parse("2024-03-01")));

            Console.ReadKey();
            
        }
    }
}
