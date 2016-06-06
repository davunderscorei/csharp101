using System;

namespace Csharp101_1._1.Types
{
    /// <summary>
    /// Boxing allows standard value types to be swapped with their 
    /// reference type equivalent automatically (and vice-versa)
    /// </summary>
    class Boxing
    {
        void Box()
        {
            Int32 myReferenceInt = 0;
            int myValueInt = myReferenceInt;

            myValueInt = 10;

            myReferenceInt = myValueInt;
        }

        void Boxes()
        {
            // the framework does the conversion for you automatically
            char c = new Char();
            byte b = new Byte();
            int i = new Int32();
            long l = new Int64();
        }
    }
}
