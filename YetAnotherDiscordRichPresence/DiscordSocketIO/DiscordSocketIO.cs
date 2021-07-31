using System;
using System.Net.Sockets;
using System.Text;

namespace YetAnotherDiscordRichPresence
{
    public class DiscordSocketIO : SocketIO
    {
        public DiscordSocketIO(ISocket discordSocket) : base(discordSocket) {}

        public override byte[] Read()
        {
            byte[] buffer = new byte[256];

            using Socket socket = DiscordSocket.GetSocketAfterConnection();
            socket.Receive(buffer);

            return buffer;
        }

        public override void Write(byte[] message)
        {
            using Socket socket = DiscordSocket.GetSocketAfterConnection();
            socket.Send(message);
        }
    }
}