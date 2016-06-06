using System;

namespace Csharp101_1.ControlFlow
{
    /// <summary>
    /// Func<> and Action<> are an upgraded form of delegates
    /// </summary>
    public class Functions
    {
        void MyBasicActionMethod()
        { }

        void MyArgActionMethod(int arg1, string arg2)
        { }

        int MyBasicFunction()
        {
            return 0;
        }

        int MyArgFunction(string arg)
        {
            return arg.Length;
        }

        void Test()
        {
            Action myAction = MyBasicActionMethod;
            myAction();

            Action<int, string> myArgAction = MyArgActionMethod;
            myArgAction(1, "hello");

            Func<int> myFunc = MyBasicFunction;
            int result = myFunc();

            Func<string, int> myArgFunc = MyArgFunction;
            int argResult = myArgFunc("hi");
        }
    }
}
