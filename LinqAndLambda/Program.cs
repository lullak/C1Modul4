namespace LinqAndLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bilar = { "Volvo", "BMW", "Audi", "Skoda",
                             "Toyota", "Ford", "Mercedes","Seat", "Honda",
                             "Volkswagen","Opel", "Mazda","Suzuki" };

            //a 

            var bilOpel = (from bil in bilar
                          where bil.Equals("Opel")
                          select bil).SingleOrDefault();

            var bilOpelLambda = bilar.Where(b => b.Equals("Opel"));

            Console.WriteLine(bilOpel);
            //b
            var bilStartsWithV = from bil in bilar
                                  where bil.StartsWith("V")
                                  select bil;

            var bilStartsWithVLambda = bilar.Where(b => b.StartsWith("V"));
            foreach (var bil in bilStartsWithV)
            {
                Console.WriteLine(bil);
            }
            //c
            var containsDA = from bil in bilar
                             where bil.Contains("da")
                             select bil;

            var contaionsDALambda = bilar.Where(b => b.Contains("da"));
            foreach (var bil in containsDA)
            {
                Console.WriteLine(bil);
            }
            //d 
            var startWithMorendsWithI = from bil in bilar
                                        where bil.StartsWith("M") || bil.EndsWith("i")
                                        select bil;

            var startWithMoreendsWtihILambda = bilar.Where(b => b.StartsWith("M") || b.EndsWith("i"));

            foreach (var bil in startWithMoreendsWtihILambda)
            {
                Console.WriteLine(bil);
            }
            Console.ReadLine();

        }
    }
}
