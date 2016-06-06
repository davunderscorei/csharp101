using System;

namespace Csharp101_1.Classes
{
    public static class Extensions
    {
        // extensions allow you to add additional methods to a class instance
        // NOT the same as monkey patching because you can't alter the internals
        public static string SayHello(this string target)
        {
            return $"Hello {target}";
        }
    }

    class Test
    {
        void Tester()
        {
            var result = Extensions.SayHello("rob"); // result = "Hello rob"
        }
    }
}
