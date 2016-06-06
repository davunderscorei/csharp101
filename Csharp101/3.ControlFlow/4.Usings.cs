using System;

namespace Csharp101_1.ControlFlow
{
    public class MyDisposableClass : IDisposable
    {
        void Using()
        {
			// approach 1
            MyDisposableClass myClass1 = new MyDisposableClass();
            // do stuff, an exception here will result in no Dispose()
            myClass1.Dispose();


			// approach 2 
            MyDisposableClass myClass2 = null;

            try
            {
                myClass2 = new MyDisposableClass();
                // do stuff
            }
            finally
            {
                myClass2.Dispose(); // this is always called
            }


            // approach 3
            using (var myClass3 = new MyDisposableClass())
            {
				// do stuff, class is always disposed
            }
        }

        public void Dispose()
        {

        }
    }
}
