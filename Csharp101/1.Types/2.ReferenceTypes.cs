using System;

namespace Csharp101_1.Types
{
    class ReferenceTypes
    {
        void ExampleReferenceTypes()
        {
            // reference types are pointers to an instance on the heap (typically)
            // you pass them around by copying the pointer, not the instance

            Object myObject = new Object(); // myObject is a pointer/reference
            ReferenceTypes myRefTypes = new ReferenceTypes();

            // copy the myRefTypes pointer to the stack to call MyMethod
            MyMethod(myRefTypes);
        }

        void MyMethod(ReferenceTypes myRefTypes)
        {
            // do stuff with myRefTypes
        }
    }
}
