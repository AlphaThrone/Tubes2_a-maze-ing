﻿using System;
using ControllerFile;
namespace amazeing
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.importMaze();
            controller.solve();


            Console.ReadKey();
        }
    }
}
