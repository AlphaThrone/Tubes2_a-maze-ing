using System;
using ControllerFile;
namespace amazeing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Controller controller = new Controller();
            controller.importMaze();
            controller.solve();


            Console.ReadKey();
        }
    }
}
