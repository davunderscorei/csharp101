namespace Csharp101_1.Classes
{
    class Statics
    {
        // static fields can be accessed without creating a new instance
        public static int MyStaticField;

        // instance fields are unique to each instance
        public int MyInstanceField;
    }

    class StaticTest
    {
        void Test()
        {
            Statics.MyStaticField = 9;

            Statics instance1 = new Statics();
            instance1.MyInstanceField = 1; // unique to instance1

            Statics instance2 = new Statics();
            instance2.MyInstanceField = 2; // unique to instance2
        }
    }
}
