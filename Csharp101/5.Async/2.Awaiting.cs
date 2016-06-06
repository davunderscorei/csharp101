using System.Threading.Tasks;

namespace Csharp101_1.Async
{
    class Awaiting
    {
        Task SetupSomeFutureWork()
        {
            return Task.CompletedTask;
        }
        
        Task<int> SetupSomeFutureNumberWork()
        {
            return Task.FromResult(123);
        }

        // async tells the compiler that this method is going to
        // execute and await one or more Tasks
        async void Tester()
        {
            // await releases the current thread until the work has completed
            // then signals for its return
            await SetupSomeFutureWork();

            var result = await SetupSomeFutureNumberWork();
        }
    }
}
