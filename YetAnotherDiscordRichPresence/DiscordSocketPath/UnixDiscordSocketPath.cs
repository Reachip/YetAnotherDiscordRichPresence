using System;
namespace YetAnotherDiscordRichPresence
{
    public class UnixDiscordSocketPath : IDiscordSocketPath
    {
        public string GetPath()
        {
            string path = Environment.GetEnvironmentVariable("TEMP");
            path ??= Environment.GetEnvironmentVariable("TMPDIR");
            path ??= Environment.GetEnvironmentVariable("XDG_RUNTIME_DIR");
            path ??= Environment.GetEnvironmentVariable("TMP");
            path ??= "/tmp";

            return path + "discord-ipc-0";
        }
    }
}
