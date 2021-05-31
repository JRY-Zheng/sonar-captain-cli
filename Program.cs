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
        static ConsoleKey GetKey(params ConsoleKey[] keys)
        {
            while (true)
            {
                ConsoleKey command = Console.ReadKey().Key;
                foreach (ConsoleKey key in keys)
                {
                    if (command == key)
                    {
                        return command;
                    }
                }
                Console.WriteLine("命令不正确，请重新输入：");
            }
        }
        static void Main(string[] args)
        {
            Game game = new Game();
            GameState gameState = GameState.START;
            while(true)
            {
                if (gameState == GameState.START)
                {
                    Console.WriteLine("深海谍影开始游戏。请输入c创建房间，或者a加入房间：");
                    ConsoleKey command = GetKey(ConsoleKey.C, ConsoleKey.A);
                    game.StartHandler();
                    if (command == ConsoleKey.C)
                    {
                        gameState = GameState.INITIAL;
                    }
                    else if (command == ConsoleKey.A)
                    {
                        gameState = GameState.WAIT4START;
                    }
                }
                else
                {
                    Console.WriteLine(gameState);
                    return;
                }
            }
        }
    }
}
