using System.Diagnostics;

namespace CALinq6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] namnLista = { "Karl Folkesson", "Sven Karlsson", "Greta Blom" };

            //var sortLastName = from lastName in namnLista
            //                   orderby lastName.Substring(lastName.IndexOf(" ")) ascending
            //                   select lastName;
            //foreach (var lastName in sortLastName)
            //{
            //    Console.WriteLine(lastName);
            //}

            //var sortLastName2 = namnLista.OrderBy(lastName => lastName.Substring(lastName.IndexOf(" ")));
            //foreach (var lastName in sortLastName2)
            //{
            //    Console.WriteLine(lastName);
            //}

            //int[] lista = { 1, 3, 5, 7 };

            //var incBy2 = (from list in lista
            //             select list + 2).ToList();
            //foreach (var list in incBy2)
            //{
            //    Console.WriteLine(list);
            //}

            //var incBy3 = lista.Select(list => list + 3).ToList();
            //foreach (var list in incBy3)
            //{
            //    Console.WriteLine(list);
            //}

            string fullText = "Flygande beckasiner söka whila på mjuka tufvor";
            var vokaler = (from vokal in fullText
                           where "AEIOUYÅÄÖ".Contains(char.ToUpper(vokal))
                           select vokal).Count();
            Console.WriteLine(vokaler);

            var vokaler1 = fullText.Where(v => "AEIOUYÅÄÖ".Contains(char.ToUpper(v))).ToList();
            Console.WriteLine(String.Join(",", vokaler1));
            foreach (var vokal in vokaler1) 
            {
                Console.WriteLine(vokal);
            }

            var miljonen = Enumerable.Range(1,1000000).ToArray();
            var miljonen1 = Enumerable.Range(1, 1000000).ToList();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var calcAvg = (from miljon in miljonen
                          select miljon).Average();
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            sw.Start();
            var calcAvg1 = (from miljon in miljonen1
                           select miljon).Average();
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            sw.Start();
            var miljonen2 = miljonen.Average();
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            sw.Start();
            var miljonen3 = miljonen1.Average();
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            Console.ReadLine();
        }
    }
}
