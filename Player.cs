using System.Drawing;
using System.Net.Sockets;

namespace Rally
{
    internal class Player : Car
    {
        private readonly Client client;

        public PlayerState State { get; set; }

        public string Nick { private set; get; }
        public bool Connected => client.Connected;
        public Client Client => client;

        public Player(Socket socket)
        {
            client = new Client(socket);
            State = PlayerState.Waiting;
        }

        public Command? AcceptCommand()
        {
            var number = client.AcceptInt();
            if (number == null)
                return null;
            return (Command)number;
        }

        public bool SendPosition(PointF position)
        {
            if (!client.SendFloat(position.X))
                return false;
            if (!client.SendFloat(position.Y))
                return false;
            return true;
        }

        public bool Disconnect()
        {
            client.Disconnect();
            return true;
        }
    }

    public enum PlayerState
    { 
        Waiting,
        Playing
    }
}
