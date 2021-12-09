using System.Text.Json.Serialization;

namespace CardFinder.Models
{
    internal class BestBuyQueryResponse
    {
        [JsonPropertyName("from")]
        public int From { get; set; }

        [JsonPropertyName("to")]
        public int To { get; set; }

        [JsonPropertyName("currentPage")]
        public int CurrentPage { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("totalPages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("queryTime")]
        public string QueryTime { get; set; } = "";

        [JsonPropertyName("totalTime")]
        public string TotalTime { get; set; } = "";

        [JsonPropertyName("partial")]
        public bool Partial { get; set; }

        [JsonPropertyName("products")]
        public List<BestBuyProduct> Products { get; set; } = new List<BestBuyProduct>();
    }
}
