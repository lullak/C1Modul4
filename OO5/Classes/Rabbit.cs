namespace OO5.Classes
{
    public class Rabbit : Herbivore
    {
        public override Size Size { get; set; }

        public Rabbit()
        {
            Size = Size.Large;
        }

        public override string Speak()
        {
            return "dunno!";
        }

        public override string ToString()
        {
            return $"Rabbit";
        }
    }
}
