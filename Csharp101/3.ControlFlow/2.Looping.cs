using System;

namespace Csharp101_1.ControlFlow
{
    class Looping
    {
        void Loops()
        {
            while (true)
            {
                // skip to next iteration
                continue;

                // stop looping
                break;
            }

            do
            {
                // loop (in this case just once)
            }
            while (false);

            for (var i = 0; i < 100; i++)
            {
                // loop 100 times (you can also use continue/break here too)
            }

            int[] items = new[] { 1, 2, 3, 4, 5 };

            foreach (var item in items)
            {
                Console.WriteLine($"Item is: {item}");
            }
        }
    }
}
