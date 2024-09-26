namespace WinFormsExtensionsDemo1.Extensions
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            string[] words = str.Split(" ");
            return words.Length;
        }

        public static string[] GetWordArray(this string str)
        {
            return str.Split(" ");
        }
    }
}
