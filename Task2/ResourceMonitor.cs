using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ResourceMonitor
    {
        long maxMemory;

        public ResourceMonitor(long maxMemory)
        {
            this.maxMemory = maxMemory;
        }
        public void CheckMemory()
        {
            long currentMemoryUsage = GC.GetTotalMemory(false);
            if (currentMemoryUsage >= maxMemory)
            {
                Console.WriteLine($"Warning! Current memory usage: {currentMemoryUsage}, it's on the verge of established limit: {maxMemory}");
            }
        }
    }
}
