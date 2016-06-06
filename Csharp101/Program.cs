/*
    C# uses C-style comments
*/

// using is like import/require, although doesn't execute code
using System;

// namespace is like a Ruby Module or an Objective C ..er.. prefix?
namespace Csharp101
{
    public class Program
    {
        // our program entry point, must be static and must be called "Main"
        static void Main(string[] args)
        {
            // almost all statements are completed with a semi-colon
            Console.WriteLine("Hello world!"); 
        }
    }
}
