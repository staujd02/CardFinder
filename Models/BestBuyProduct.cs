using System.Text.Json.Serialization;

namespace CardFinder.Models
{
    internal class BestBuyProduct
    {
        [JsonPropertyName("addToCartUrl")]
        public string? AddToCartUrl { get; set; }

        [JsonPropertyName("condition")]
        public string? Condition { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("dollarSavings")]
        public decimal? DollarSavings { get; set; }

        [JsonPropertyName("freeShipping")]
        public bool FreeShipping { get; set; }

        [JsonPropertyName("inStoreAvailability")]
        public bool InStoreAvailability { get; set; }
        [JsonPropertyName("inStoreAvailabilityText")]
        public string? InStoreAvailabilityText { get; set; }
        [JsonPropertyName("manufacturer")]
        public string? Manufacturer { get; set; }

        [JsonPropertyName("mobileUrl")]
        public string? MobileUrl { get; set; }

        [JsonPropertyName("modelNumber")]
        public string? ModelNumber { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("onlineAvailability")]
        public bool OnlineAvailability { get; set; }
        [JsonPropertyName("onlineAvailabilityText")]
        public string? OnlineAvailabilityText { get; set; }
        [JsonPropertyName("onSale")]
        public bool OnSale { get; set; }
        [JsonPropertyName("percentSavings")]
        public string? PercentSavings { get; set; }
        [JsonPropertyName("preowned")]
        public bool Preowned { get; set; }
        [JsonPropertyName("regularPrice")]
        public decimal RegularPrice { get; set; }
        [JsonPropertyName("salePrice")]
        public decimal SalePrice { get; set; }
        [JsonPropertyName("shortDescription")]
        public string? ShortDescription { get; set; }
        [JsonPropertyName("sku")]
        public int SKU { get; set; }
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        public string GetInfo()
        {
            return Name + " - " + ModelNumber;
        }
    }
}
