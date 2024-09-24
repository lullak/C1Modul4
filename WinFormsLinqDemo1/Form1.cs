namespace WinFormsLinqDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LINQToString();
            LINQToNumbers();
        }

        private void LINQToString()
        {
            List<string> nameList = new List<string>() { "Kalle", "Anna", "Lisa", "Emma", "Linda", "Johan" };

            List<string> result = (from name in nameList
                                   where name.ToUpper().Contains("E") && name != "Emma"
                                   select name).ToList();

            foreach (var name in nameList)
            {
                if (name.ToUpper().Contains("E"))
                {

                }

            }
        }
        private void LINQToNumbers()
        {
            List<int> numberList = new List<int>() { 1, 4, 8, 12, 15, 32, 25, 45, 56, 78, 19, 76 };

            List<int> result = (from number in numberList
                                   where number >= 10 && number <= 25
                                   orderby number descending
                                   select number).ToList();

   
        }
    }
}
