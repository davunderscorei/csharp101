using System;

namespace Csharp101_1.ControlFlow
{
    class Exceptions
    {
        void TestError()
        {
            throw new InvalidOperationException("Eek! Something went wrong!");

            // never get here
            return;
        }

        void TryCatch()
        {
            try
            {
                TestError();
            }
            catch (InvalidOperationException invalidEx)
            {
                // catch specific type of exception
            }
            catch (Exception ex)
            {
                // catch any exceptions thrown by TestError()
            }

            // this runs
            return;
        }

        void Finally()
        {
            try
            {
                TestError();
            }
            finally
            {
                // ALWAYS run this block regardless of any exceptions
            }
        }
    }
}
