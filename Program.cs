using System;

namespace sonar_captain
{
    class Program
    {
        enum GameState
        {
            START, INITIAL, WAIT4START, OPERATION, 
            MAP, MASK, ENGINEER, WORKER, ACTION,
            DETECT, CHECKOUT, WAITING, END
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
