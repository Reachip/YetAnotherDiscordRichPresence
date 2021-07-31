using System;

namespace YetAnotherDiscordRichPresence
{
    public abstract class SocketIO
    {
        public ISocket DiscordSocket { get; set; }

        public SocketIO(ISocket discordSocket)
        {
            DiscordSocket = discordSocket;
        }

        public abstract byte[] Read();
        public abstract void Write(byte[] message);
    }
}
