using System;
using System.IO;

namespace YetAnotherDiscordRichPresence
{
    public class DiscordRPClient
    {
        public DiscordSocketIO DiscordSocketIO { get; set; }

        public DiscordRPClient(ISocket discordSocket)
        {
            DiscordSocketIO = new DiscordSocketIO(discordSocket);
        }

        public void HandShake()
        {
            DiscordSocketIO.Write(DiscordRequest.Request(OpCode.Handshake, new HandShakePayload()));
        }

        public void SetActivity()
        {
            DiscordSocketIO.Write(DiscordRequest.Request(OpCode.Pong, new SetActivityPayload()));
        }
    }
}
