using OO1.Classes;

namespace OO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Animal> animals = new List<Animal>();
        private void buttonSound_Click(object sender, EventArgs e)
        {
            listViewAnimals.Items.Clear();
            foreach (Animal a in animals)
            {
                listViewAnimals.Items.Add(a.AnimalSound());
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (radioButtonMonkey.Checked)
            {
                Monkey monkey = new Monkey();
                animals.Add(monkey);
            }
            if (radioButtonCow.Checked)
            {
                Cow cow = new Cow();
                animals.Add(cow);
            }
            if (radioButtonCat.Checked)
            {
                Cat cat = new Cat();
                animals.Add(cat);
            }
            if (radioButtonDog.Checked)
            {
                Dog dog = new Dog();
                animals.Add(dog);
            }
        }
    }
}
