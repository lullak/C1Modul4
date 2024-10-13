namespace Ext1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "23a";
            bool number1 = name.IsNumeric(out int number);

            Console.WriteLine(number1);
            Console.WriteLine(number);

            Console.ReadLine();
        }

    }
    public static class MyExtensions
    {
        public static bool IsNumeric(this string s, out int number)
        {
            return int.TryParse(s, out number);
        }
    }
}
