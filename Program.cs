using CardFinder.Pacers;
using CardFinder.Processors;
using CardFinder.Reporter;
using CardFinder.Requests;

namespace CardFinder
{

    public class CardFinder
    {

        private static readonly HttpClient client = new HttpClient();

        public static async Task Main(string[] args)
        {
            // 9001G1332530000
            // VCGGT10302PB-BB
            Console.WriteLine("Enter the model number:");
            var modelToAquire = Console.ReadLine();
            while (true)
            {
                var response = await SearchForCardQuery.Execute(client, modelToAquire.Trim());
                Console.WriteLine($"Query Time: {response.QueryTime}");
                var foundCard = SearchResponseForItem.Execute(response);
                if (foundCard != null)
                {
                    FoundTargetCardReporter.Execute(foundCard);
                    break;
                }
                await SlowPacer.Wait();
            }

            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
    }
}
