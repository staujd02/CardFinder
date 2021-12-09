using CardFinder.Models;
using System.Text;
using System.Text.Json;

namespace CardFinder.Requests
{
    internal class SearchForCardQuery
    {
        public static async Task<BestBuyQueryResponse> Execute(HttpClient client, string modelNumber)
        {
            var key = File.ReadAllText(@"secret.txt", Encoding.UTF8).Trim();
            var streamTask = client.GetStreamAsync($"https://api.bestbuy.com/v1/products(modelNumber={modelNumber})?apiKey={key}&sort=condition.asc&show=addToCartUrl,condition,description,dollarSavings,freeShipping,inStoreAvailability,inStoreAvailabilityText,manufacturer,mobileUrl,modelNumber,name,onlineAvailability,onlineAvailabilityText,onSale,percentSavings,preowned,regularPrice,salePrice,shortDescription,sku,type&format=json");
            return await JsonSerializer.DeserializeAsync<BestBuyQueryResponse>(await streamTask);
        }
    }
}
