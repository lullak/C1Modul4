using DemoInterfaceStatic.Interfaces;

namespace DemoInterfaceStatic.Classes
{
    internal class WashingMachine : IPowerPlug
    {
        public void Connect(int voltage, int ampere)
        {
            throw new NotImplementedException();
        }

        public void Disconnect(int voltage, int ampere)
        {
            throw new NotImplementedException();
        }
    }
}
