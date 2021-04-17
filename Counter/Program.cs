using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.GetCount(100);
            Console.ReadKey();
        }
    }
}
