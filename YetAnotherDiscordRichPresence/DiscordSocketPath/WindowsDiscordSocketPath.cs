using System;
namespace YetAnotherDiscordRichPresence
{
    public class WindowsDiscordSocketPath : IDiscordSocketPath
    {
        public string GetPath() => "\\\\?\\pipe\\discord-ipc-0";   
    }
}
