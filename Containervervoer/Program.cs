using Containervervoer.Classes;

namespace Containervervoer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new ContainerTransport());
        }
    }
}