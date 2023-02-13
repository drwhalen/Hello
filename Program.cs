using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Added another line");
            Console.WriteLine("Fix the bug");

            // Try to create merge conflict
            if (false)
                Console.WriteLine("Unreachable");
            else
                Console.WriteLine("Added inside of IF");

            Console.WriteLine("Added this for Jay");
        }
    }
}