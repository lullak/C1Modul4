namespace OO5.Classes
{
    public class Cow : Herbivore
    {
        public override Size Size { get; set; }

        public Cow()
        {
            Size = Size.Large;
        }

        public override string Speak()
        {
            return "MOOO!";
        }
        public override string ToString()
        {
            return $"Cow";
        }
    }
}
