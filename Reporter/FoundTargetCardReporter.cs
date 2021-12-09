using CardFinder.Models;
using System.Diagnostics;

namespace CardFinder.Reporter
{
    internal class FoundTargetCardReporter
    {

        public static void Execute(BestBuyProduct response)
        {
            Console.WriteLine("Found Card:");
            Console.WriteLine(response.GetInfo());
            Console.WriteLine("Order Here:");
            var info = new ProcessStartInfo(response.AddToCartUrl);
            info.UseShellExecute = true;
            Process.Start(info);
        }

    }
}
