using Newtonsoft.Json;

namespace OSRS_ToG_Worlds
{
    public class WorldInfo
    {
        [JsonProperty("world_number")]
        public int World { get; set; }

        [JsonProperty("hits")]
        public int Hits { get; set; }

        [JsonProperty("stream_order")]
        public string Order { get; set; }
    }
}
