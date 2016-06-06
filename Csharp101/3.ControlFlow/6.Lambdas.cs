using System;

namespace Csharp101_1.ControlFlow
{
    class Lambdas
    {
        void MyAction()
        {
            Console.WriteLine("Hello world");
        }

        void ActionLambdas()
        {
            // action #1
            MyAction();

            // action #2
            Action myAction = MyAction;
            myAction();

            // action #3
            myAction = () =>
            {
                Console.WriteLine("Hello world");
            };
            myAction();

            // action #4
            myAction = () => Console.WriteLine("Hello world");
            myAction();
        }

        string MyFunc(int count)
        {
            return $"Hello world: {count}";
        }

        void FunctionLambdas()
        {
            // approach #1
            MyFunc(1);

            // approach #2
            Func<int, string> myFunc = MyFunc;
            myFunc(2);

            // approach #3
            myFunc = (count) =>
            {
                return $"Hello world: {count}";
            };
            myFunc(3);

            // approach #4
            myFunc = count => $"Hello world {count}";
            myFunc(4);
        }
    }
}
