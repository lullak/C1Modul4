using DemoJsonIntro.Classes;

namespace DemoJsonIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Filehandler filehandler = new Filehandler("product.json");
            List<Product> products = filehandler.GetAllProducts();
        }

    }
}
