using System;

namespace ProgramStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to the Structure of a C# Program Demo!");

            // Ask user for name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Greet the user
            Console.WriteLine("Hello " + name + "!");

            // Display program structure information
            Console.WriteLine("\nProgram Structure Demonstrated:");
            Console.WriteLine("1. using System : imports functionality");
            Console.WriteLine("2. namespace : organizes code");
            Console.WriteLine("3. class Program : container for code");
            Console.WriteLine("4. Main() : entry point of program");
            Console.WriteLine("5. Comments : explain logic and documentation");

            // Final message
            Console.WriteLine("\nProgram executed successfully!");
        }
    }
}