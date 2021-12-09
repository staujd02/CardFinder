namespace CardFinder.Pacers
{
    internal class SlowPacer
    {
        public static Task Wait()
        {
            return Task.Delay(5000);
        }
    }
}
