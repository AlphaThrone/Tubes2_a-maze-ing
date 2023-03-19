using System;
using amazeing;

namespace amazeing
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.importMaze();
            controller.displayMazeFileName();
            controller.displayMazeFilePath();

            Console.ReadKey();
        }
    }
}
