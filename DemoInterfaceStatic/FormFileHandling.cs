using DemoInterfaceStatic.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoInterfaceStatic
{
    public partial class FormFileHandling : Form
    {
        public FormFileHandling()
        {
            InitializeComponent();
        }

        private void buttonWriteTextToFile_Click(object sender, EventArgs e)
        {
            Filehandler.WriteToFile(textBoxText.Text);
        }
    }
}
