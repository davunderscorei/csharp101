using System;

namespace Csharp101_1.ControlFlow
{
    class Conditionals
    {
        void IfElse()
        {
            if (1 == 2)
            {
                // do something
            }
            else if (false)
            {
                // do something else
            }
            else
            {
                // if all else fails, do this
            }

            if (true)
                Console.WriteLine("It's true!");

            if (!true || false && 2 == 8)
                Console.WriteLine("It's false!");
        }
    }
}
