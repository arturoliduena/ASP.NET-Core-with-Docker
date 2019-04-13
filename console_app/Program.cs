using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 10;
            var stop = 0;
            while(counter >= stop)
            {
                Console.WriteLine($"Counter: {counter}");
                counter--;
                System.Threading.Tasks.Task.Delay(1000).Wait();
            }
        }
    }
}
