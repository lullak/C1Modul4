using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace Ext1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "23";
            bool isNumber = name.IsNumeric(out int number);

            Console.WriteLine($"{isNumber}, number: {number}");

            Console.ReadLine();
        }

    }
    public static class MyExtensions
    {
        public static bool IsNumeric(this string s, out int number)
        {
            return int.TryParse(s, out number);
        }




            //2. Skapa en Extension Method för String.Den skall ta emot en sträng med olika ord som särskiljs av
            //mellanslag. Metoden skall göra om första bokstaven i varje ord så att den blir stor. Döp den till
            //UppercaseWordFirstLetter.
            //string namn = "nackademin yrkeshögskola";
            //        namn = namn.UppercaseWordFirstLetter(); //Skall ge "Nackademin Yrkeshögskola"

            //3. Skriv en Extension Method för DateTime, som returnerar datumet för sista dagen i månaden
            //för det datum man använder metoden på:
            //var lastDate = DateTime.Now.GetLastDateOfMonth();
            //        Om det t ex är den 11 oktober 2015 när koden ovan körs, så returneras ett datumobjekt som
            // innehåller den 31 oktober 2015. Tänk på att metoden måsta klara skott-år(dvs februari med
            // 29 dagar).

            //4. Skapa en extension method som du döper till ListToString.Den skall ta emot en lista med
            //strängar och ”platta till den” så den returnerar en kommaseparerad sträng med alla värden i
            //listan.Använd StringBuilder klassen för att skapa strängen.

            //5. Skapa en extension method.Den skall vara en overload på metoden Add som finns för en lista
            //av integers. Den vanliga Add metoden tar bara ett tal i taget. Den metod som du skall skapa skall
            //ta en array med valfritt antal tal och lägga in alla samtidigt i listan. Ett tips är att använda params
            //nyckelordet.Metoden skall kunna anropas på detta sätt.
            // List<int> tal = new List<int>();
            //tal.Add(7, 8, 9, 10);
    }
}
