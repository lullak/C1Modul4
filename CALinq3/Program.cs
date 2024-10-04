namespace CALinq3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>() { 54, 23, 76, 123, 93, 7, 3489, 88 };

            var avg = (from ints in integers
                       select ints).Average();

            var avg1 = integers.Average(ints => ints);

            Console.WriteLine(avg);
            Console.WriteLine(avg1);

            var max = (from ints in integers
                       select ints).Max();

            var max1 = integers.Max(ints => ints);
            Console.WriteLine(max);
            Console.WriteLine(max1);

            var min = (from ints in integers
                       select ints).Min();
            var min1 = integers.Min(ints => ints);
            Console.WriteLine(min);
            Console.WriteLine(min1);

            var sum = (from ints in integers
                       select ints).Sum();
            var sum1 = integers.Sum(ints => ints);
            Console.WriteLine(sum);
            Console.WriteLine(sum1);

            var evenint = from ints in integers
                           where ints % 2 == 0
                           select ints;

            var evenint2 = integers.Where(i => i % 2 == 0);

            foreach (var ints in evenint)
            {
                Console.WriteLine(ints);
            }
            foreach (var ints in evenint2)
            {
                Console.WriteLine(ints);
            }

            var result = Enumerable.Range(1,10).ToList();

            foreach (var ints in result)
            {
                Console.WriteLine(ints);
            }

            Console.ReadKey();
        }
    }
}
