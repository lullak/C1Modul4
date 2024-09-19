namespace DemoInterfaceStatic.Classes
{
    public static class Filehandler
    {
         
        private static string _filePath = @"text.txt";
        // Detta funkar inte i en statisk klass kan inte ha en konstructor.
        //public Filehandler() { }

        public static void WriteToFile(string text)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine(text);
            }
        }
    }
}
