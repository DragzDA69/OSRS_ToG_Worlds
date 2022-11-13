using Newtonsoft.Json;

namespace OSRS_ToG_Worlds
{
    public class APIHelper
    {
        private static readonly string WORLD_INFO_ENDPOINT = "https://www.togcrowdsourcing.com/worldinfo";
        private static readonly string LAST_RESET_ENDPOINT = "https://www.togcrowdsourcing.com/lastreset";

        public static async Task<List<WorldInfo>> GetWorldInfo()
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync(WORLD_INFO_ENDPOINT);
                var list = JsonConvert.DeserializeObject<List<WorldInfo>>(json);
                return list ?? new List<WorldInfo>();
            }
        }

        public static async Task<ResetInfo> GetLastResetInfo()
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync(LAST_RESET_ENDPOINT);
                var list = JsonConvert.DeserializeObject<ResetInfo>(json);
                return list ?? new ResetInfo();
            }
        }
    }
}
