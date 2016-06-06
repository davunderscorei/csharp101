using System;

namespace Csharp101_1.Classes
{
    class Methods
    {
        void MyMethod1()
        {
            // do stuff
            return;
        }

        int MyMethod2()
        {
            // do stuff
            return 0;
        }

        int MyMethod3(int param1)
        {
            // do stuff
            return param1 + 1;
        }

        // params allow variable length parameters to be passed in
        int MyParamMethod(params int[] myParams)
        {
            // do stuff
            return myParams.Length;
        }

        void ParamsTest()
        {
            MyParamMethod(0);
            MyParamMethod(0, 1);
            MyParamMethod(0, 2, 3, 4, 5, 6);
        }

        // defaults are set if the parameter isn't specified
        void MyDefaultParams(int myParam = 123)
        {
            Console.WriteLine(myParam);
        }

        void DefaultTest()
        {
            MyDefaultParams(); // prints 123
            MyDefaultParams(321); // prints 321
        }

        void MyNamedMethodParams(int joe = 0, string lucy = null)
        {

        }

        void NamedTest()
        {
            // named parameters allow you to clearly specify which
            // parameters you are supplying
            MyNamedMethodParams(lucy: "hello");
        }
    }
}
