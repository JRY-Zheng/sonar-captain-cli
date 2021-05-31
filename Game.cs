namespace sonar_captain
{
    class Game
    {
        public string room {get; private set;}

        public bool SetRoomName(string roomName)
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
    }
}