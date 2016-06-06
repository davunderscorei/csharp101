using System.Threading.Tasks;

namespace Csharp101_1.Async
{
    class Tasks
    {
        Task SetupSomeFutureWork()
        {
            return Task.CompletedTask;
        }

        void Tester()
        {
            var futureWork = SetupSomeFutureWork();

            // executes the Task asynchronously on another thread
            futureWork.Start();

            // block this thread until the Task thread has completed its work
            futureWork.Wait();
        }

        Task<int> SetupSomeFutureNumberWork()
        {
            return Task.FromResult(123);
        }

        void NumberTester()
        {
            var futureWork = SetupSomeFutureNumberWork();

            // executes the Task asynchronously on another thread
            futureWork.Start();

            // block this thread until the Task thread has completed its work
            futureWork.Wait();

            // this will be 123
            var result = futureWork.Result;
        }
    }
}
