using System;
using Newtonsoft.Json;

namespace YetAnotherDiscordRichPresence
{
    public class BasePayload
    {
        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
