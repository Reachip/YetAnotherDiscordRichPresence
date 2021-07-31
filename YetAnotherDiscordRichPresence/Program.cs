using System;
using System.Threading;

namespace YetAnotherDiscordRichPresence
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscordSocket discordSocket = new DiscordSocket();
            DiscordRPClient client = new DiscordRPClient(discordSocket);

            client.HandShake();
            client.SetActivity();
        }
    }
}
