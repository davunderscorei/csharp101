using System;

namespace Csharp101_1.Types
{
    class ObjectTutorial
    {
        void AllTypesInheritObject()
        {
            object anInteger = 0;
            object aString = "hello";
            object anArray = new int[] { 1, 2, 3 };
            object aClass = new ObjectTutorial();
        }
    }
}