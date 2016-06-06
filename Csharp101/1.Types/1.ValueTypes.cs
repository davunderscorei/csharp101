namespace Csharp101_1.Types
{
    class ValueTypes
    {
        void ExampleValueTypes()
        {
            // value types are known quantities of stack-based memory
            // you pass them around by copying them
            char myChar = 'a';
            byte myByte = 0;
            int myInt = 0;
            long myLong = 0;

            MyExampleStructValueType myStruct = new MyExampleStructValueType();
        }
    }

    /// <summary>
    /// A struct is a fixed size object that can not inherit
    /// but can contain methods/properties
    /// 
    /// Like basic value types, structs are copied when being passed around
    /// </summary>
    struct MyExampleStructValueType
    {
        int PointX;
        int PointY;
    }
}
