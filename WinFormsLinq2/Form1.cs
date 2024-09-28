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

            //var result = (from band in bands
            //               orderby band.Length descending
            //               select band).First();
            //var result = bands.OrderByDescending(b => b.Length).First();

            //MessageBox.Show(result);
            //

            //var result = (from band in bands
            //              orderby band.Length ascending
            //              select band).First();
            //var result = bands.OrderBy(b => b.Length).First();
            //MessageBox.Show(result);

            //var result = (from band in bands
            //              where band.StartsWith("M")
            //              select band).Count();

            //var result = bands.Where(b => b.StartsWith("M")).Count();
            //var resultString = String.Join(",", result);
            //MessageBox.Show(resultString);

            //var result = (from band in bands
            //              where band.Length > 6
            //              select band).ToList();

            //var result = bands.Where(b => b.Length > 6).ToList();
            //var resultString = String.Join(",", result);
            //MessageBox.Show(resultString);

            //var result = from band in bands
            //             orderby band.Length ascending
            //             select band;

            //var result = bands.OrderBy(b => b.Length).ToList();

            //var resultString = String.Join(", ", result);
            //MessageBox.Show(resultString);
        }
    }
}
