using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = Program.GetGreeting(["Hello", "world"]);
            //Console.WriteLine(message);
        }

        static private string GetGreeting(string[] args) {
            Console.WriteLine(args);
            //return args;
        }

    }
}
