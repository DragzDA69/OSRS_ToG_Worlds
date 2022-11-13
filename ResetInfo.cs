using Newtonsoft.Json;

namespace OSRS_ToG_Worlds
{
    public class ResetInfo
    {
        [JsonProperty("reset_time")]
        public string reset_time { get; set; }

        [JsonProperty("last_reset_time_unix")]
        public int last_reset_time_unix { get; set; }

        [JsonProperty("last_server_uptime")]
        public int last_server_uptime { get; set; }
    }
}
