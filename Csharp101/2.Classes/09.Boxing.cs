using System;

namespace Csharp101_1.Classes
{
    class ObjectAndBoxing
    {
        void BoxingAndUnBoxing()
        {
            int aValueType = 42; // on the stack
            object aReferenceToTheValueType = aValueType; // boxing: a copy of the value is now on the heap
            
            Console.WriteLine(aValueType); // prints "42"
            Console.WriteLine(aReferenceToTheValueType); // prints "42"
            
            /* ~~~ */

            // changing the original value won't change `aReferenceToTheValueType`
            aValueType = 123;
            
            Console.WriteLine(aValueType); // prints "123"
            Console.WriteLine(aReferenceToTheValueType); // prints "42"
            
            /* ~~~ */

            // you can "unbox" a reference type to a value type
            int aNewValueType = (int)aReferenceToTheValueType;
        
            Console.WriteLine(aNewValueType); // prints "42"

            /* ~~~ */
            
            // now all three of the variables are independant
            aNewValueType = 456;
            Console.WriteLine(aValueType); // prints "123"
            Console.WriteLine(aReferenceToTheValueType); // prints "42"
            Console.WriteLine(aNewValueType); // prints "456"
        }
        
        void WhenBoxingHappens()
        {
            /* boxing happens when the value of a value type is converted to a reference type */
            object one = 1;
            IComparable two = 2;
            SomeMethod(3);
        }
        
        void SomeMethod(object obj)
        {
        }
        
        void WhenBoxingDoesntHappen()
        {
            /* 
                boxing does not occur when converting a value of a reference type to an object
                that's just a reference conversion
            */
            ObjectAndBoxing someClass = new ObjectAndBoxing();
            object noBoxing = someClass;
        }
    }
}