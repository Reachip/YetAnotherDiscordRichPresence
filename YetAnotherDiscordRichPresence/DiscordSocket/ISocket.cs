using System;
using System.Net.Sockets;

namespace YetAnotherDiscordRichPresence
{
    public interface ISocket
    {
        public Socket GetSocketAfterConnection();
    }
}
