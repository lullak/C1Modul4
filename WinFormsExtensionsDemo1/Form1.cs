using WinFormsExtensionsDemo1.Extensions;

namespace WinFormsExtensionsDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int noOfWords = text.WordCount();

            string[] words = text.GetWordArray();
        }
    }
}
