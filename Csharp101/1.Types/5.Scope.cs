using System;

namespace Csharp101_1.Types
{
    class Scope
    {
        // class scoped field
        int myVariable = 9;

        void MyMethod1()
        {
            // method scoped field
            int myVariable = 0;
            Console.WriteLine(myVariable); // prints 0
        }

        void MyMethod2()
        {
            Console.WriteLine(myVariable); // prints 9
        }

        void MyMethod3()
        {
            this.myVariable = 5;
            Console.WriteLine(myVariable); // prints 5
        }

        void MyMethod4()
        {
            {
                // block scoped field
                int myVariable = 5;
            }

            Console.WriteLine(myVariable); // prints 9
        }
    }
}
