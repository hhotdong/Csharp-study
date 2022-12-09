using System;
using System.Threading.Tasks;

namespace AsyncTest
{
    class MainClass
    {
        public static async Task Main(string[] args)
        {
            var task = await TestAsync();
            Console.WriteLine($"Task Test C: {task}");
        }

        private static async Task<string> TestAsync()
        {
            Console.WriteLine("Task Test A");
            await Task.Delay(1000);
            Console.WriteLine("Task Test B");
            return "Complete";
        }
    }
}
