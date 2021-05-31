using System;

namespace sonar_captain
{
    class Game
    {
        public string room {get; private set;}

        private bool SetRoomName(string roomName)
        {
            if (roomName.Length == 6)
            {
                room = roomName;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void StartHandler()
        {
            while (true)
            {
                Console.WriteLine("请输入6位房间号：");
                string roomName = Console.ReadLine();
                if (SetRoomName(roomName))
                {
                    break;
                }
                Console.Write("房间号不合法，");
            }
        }
    }
}