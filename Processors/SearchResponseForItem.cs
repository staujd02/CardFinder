using CardFinder.Models;

namespace CardFinder.Processors
{
    internal class SearchResponseForItem
    {
        public static BestBuyProduct? Execute(BestBuyQueryResponse response)
        {
            return response.Products.Find(p => p.Condition == "New" && !p.Preowned && 
            (p.OnlineAvailability || p.InStoreAvailability)
            );
        }
    }
}
