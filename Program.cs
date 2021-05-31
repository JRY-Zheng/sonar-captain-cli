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
            Game game = new Game();
            GameState gameState = GameState.START;
            while(true)
            {
                if (gameState == GameState.START)
                {
                    Console.WriteLine("深海谍影开始游戏。请输入c创建房间，或者a加入房间：");
                    ConsoleKey command;
                    while (true)
                    {
                        command = Console.ReadKey().Key;
                        if (command == ConsoleKey.C || command == ConsoleKey.A)
                        {
                            break;
                        }
                        Console.WriteLine("命令必须是c或者a，请重新输入：");
                    }
                    while (true)
                    {
                        Console.WriteLine("请输入6位房间号：");
                        string roomName = Console.ReadLine();
                        if (game.SetRoomName(roomName))
                        {
                            break;
                        }
                        Console.Write("房间号不合法，");
                    }
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
