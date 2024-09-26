namespace WinFormsLambdaDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LambdaStrings();
            LambdaNumbers();
        }

        private void LambdaStrings()
        {
            List<string> nameList = new List<string>() {"Kalle","Lisa","Stina","Emma","Anna"};

            var result = nameList.Where(name => name.Length > 4 && name.Contains("a")).ToList();

            var resulyLINQQuery = (from name in nameList
                                   where name.Length > 4
                                   && name.Contains("a")
                                   select name).ToList();
        }

        private void LambdaNumbers()
        {
            List<int> numbersList = new List<int>() { 1, 4, 2, 8, 12, 28, 21, 19, 17, 33 };

            var result = numbersList.Where(number => number >= 10 && number <= 20).OrderByDescending(number => number).ToList();
            var countNumbers = numbersList.Count(number => number >= 10 && number <= 20);
        }
    }
}
