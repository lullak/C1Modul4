using System;

namespace WinFormsLinq2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth",
                                "Metallica", "Pearl Jam", "Oasis", "Abba", "Blur", "Eurythmics", "Genesis",
                                "INXS", "Midnight Oil", "Kent", "Madness", "Manic Street Preachers", "The Offspring", "Pink Floyd", 
                                "Rammstein", "Red Hot Chili Peppers", "Deep Purple", "U2"};

            int maxLength = bands.Max(band => band.Length);
            var bandList = from band in bands
                           where band == maxLength
                           select band;
                           

        }
    }
}
