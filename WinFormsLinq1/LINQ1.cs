using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLinq1
{
    public partial class LINQ1 : Form
    {
        public LINQ1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] bilar = { "Volvo", "BMW", "Audi", "Skoda",
                             "Toyota", "Ford", "Mercedes","Seat", "Honda",
                             "Volkswagen","Opel", "Mazda","Suzuki" };


            //var car = from bil in bilar
            //          where bil.Contains("Opel")
            //          select bil;

            //string carString = string.Join(", ", car);
            //MessageBox.Show(carString);


            //var car1 = from bil in bilar
            //          where bil.StartsWith("V")
            //          select bil;

            //string carString1 = string.Join(", ", car1);
            //MessageBox.Show(carString1);

            //var car1 = from bil in bilar
            //           where bil.Contains("da")
            //           select bil;

            //string carString1 = string.Join(", ", car1);
            //MessageBox.Show(carString1);
            
            var car1 = from bil in bilar
                       where bil.StartsWith("M") || bil.EndsWith("i")
                       select bil;

            string carString1 = string.Join(", ", car1);
            MessageBox.Show(carString1);

        }
    }
}
