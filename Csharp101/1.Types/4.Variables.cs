namespace Csharp101_1._1.Types
{
    class Variables
    {
        void MyMethod()
        {
            // explicit variable declaration
            int myInteger = 0;

            object myObject = 0; // Int32
            myObject = "hello"; // String

            // implicit variable declaration
            var myInferredInteger = 0; // implicitly declared as int
            // myInferredInteger = "hello"; // won't compile

            var myInferredString = "hello"; // implicitly declared as string
            // myInferredString = 0; // won't compile
        }
    }
}
