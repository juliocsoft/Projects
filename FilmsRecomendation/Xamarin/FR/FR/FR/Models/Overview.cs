using Newtonsoft.Json;

namespace FR.Models
{
    public class Overview
    {
        [JsonProperty("idoverview")]
        public int IdOverview { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("movie")]
        public Movie Movie { get; set; }
    }
}
