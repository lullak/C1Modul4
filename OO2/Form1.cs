using OO2.Classes;

namespace OO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(3000,"lidera","Fast","Kent","Anders", "Stockholm");
            Student stud = new Student(true,true,"ment","Anders", "Stockholm");

            MessageBox.Show(stud.Hello(stud.FirstName));
            MessageBox.Show(emp.Hello(emp.FirstName));
            ;
        }
    }
}
