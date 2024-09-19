using DemoInterfaceStatic.Interfaces;

namespace DemoInterfaceStatic.Classes
{
    public class Toaster : IPowerPlug, IDisposable
    {
        public void Connect(int voltage, int ampere)
        {
            throw new NotImplementedException();
        }

        public void Disconnect(int voltage, int ampere)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
