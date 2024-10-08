using OO4.Classes;

namespace OO4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> Movies = new List<Movie>();
            Movies.Add(new Movie("VÄLDIGT LÄSKIG", MovieType.Horror));
            Movies.Add(new Movie("VÄLDIGT Romantiskt", MovieType.Romance));
            Movies.Add(new Movie("VÄLDIGT Dokumentärisk", MovieType.Documentary));

            foreach (Movie item in Movies)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();

        }
    }
}
