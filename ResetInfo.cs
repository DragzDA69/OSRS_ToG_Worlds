using Newtonsoft.Json;

namespace OSRS_ToG_Worlds
{
    public class ResetInfo
    {
        [JsonProperty("reset_time")]
        public string ResetTime { get; set; }

        [JsonProperty("last_reset_time_unix")]
        public int LastResetTimeInUnix { get; set; }

        [JsonProperty("last_server_uptime")]
        public int LastServerUptime { get; set; }
    }
}
