namespace DemoInterfaceStatic.Interfaces
{
    public interface IPowerPlug
    {
        public void Connect(int voltage, int ampere);

        public void Disconnect(int voltage, int ampere);
    }
}
