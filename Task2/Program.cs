namespace Task2
{
    internal class Program
    {
        static ResourceMonitor rm = new ResourceMonitor(1_000_000);
        static void BackgroundMemoryChecker()
        {
            while (true)
            {
                rm.CheckMemory();
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            new Thread(BackgroundMemoryChecker).Start();

            int i = 0;
            while (true)
            {
                decimal[] someMoney = new decimal[1_000];
                Console.WriteLine($"Created sum number {i++}");
                Thread.Sleep(75);
            }
        }
    }
}
