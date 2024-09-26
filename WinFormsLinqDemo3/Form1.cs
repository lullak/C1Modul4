using WinFormsLinqDemo3.Classes;

namespace WinFormsLinqDemo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            comboBoxSelection.Items.Add("Instruktör");
            comboBoxSelection.Items.Add("Passtyp");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string type = comboBoxSelection.Text;
            string condition = textBoxSearchConditions.Text;
            DateTime startTime = dateTimePickerStart.Value;
            DateTime endTime = dateTimePickerStart.Value;

            List<TrainingSession> trainingSessions = TrainingSession.Search(condition, type, startTime, endTime);
            foreach (var session in trainingSessions)
            {
                listBoxSearchResults.Items.Add($"{session.Trainer.Name} {session.Type.Name} {session.StartTime.Date}" +
                    $"{session.StartTime.Date}");
            }

            listBoxSearchResults.Items.Clear();
        }
    }
}
