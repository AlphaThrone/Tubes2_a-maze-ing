﻿using System;
using amazeing;

namespace amazeing
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.importMaze();


            Console.ReadKey();
        }
    }
}
