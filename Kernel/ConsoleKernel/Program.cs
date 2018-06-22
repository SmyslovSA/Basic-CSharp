using Class;
using Humans;
using IHumans;

namespace ConsoleKernel
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new Kernel();
            kernel.Bind<IHuman, Human>();
            var user = kernel.Get<IHuman>();
        }
    }
}
