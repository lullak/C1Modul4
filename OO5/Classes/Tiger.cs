namespace OO5.Classes
{
    public class Tiger : Carnivore
    {
        public override Size Size { get; set; }

        public Tiger()
        {
            Size = Size.Large;
        }

        public override string Speak()
        {
            return "Roar!";
        }
        public override string ToString()
        {
            return $"Tiger";
        }
    }
}
