namespace OO5.Classes
{
    public class Cat : Carnivore
    {
        public override Size Size { get; set; }

        public Cat()
        {
            Size = Size.Small;
        }

        public override string Speak()
        {
            return "Mjau!";
        }

        public override string ToString()
        {
            return $"Cat";
        }
    }
}
