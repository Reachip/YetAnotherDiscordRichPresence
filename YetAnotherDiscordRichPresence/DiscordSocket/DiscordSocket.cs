using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace YetAnotherDiscordRichPresence
{
    public class DiscordSocket : ISocket
    {
        public UnixDomainSocketEndPoint UnixEndPoint { private get; set; }

        public DiscordSocket()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                UnixEndPoint = new UnixDomainSocketEndPoint(new WindowsDiscordSocketPath().GetPath());

            else
                UnixEndPoint = new UnixDomainSocketEndPoint(new UnixDiscordSocketPath().GetPath());
        }

        public Socket GetSocketAfterConnection()
        {
            var socket = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.IP);
            socket.Connect(UnixEndPoint);
            return socket;
        }
    }
}
