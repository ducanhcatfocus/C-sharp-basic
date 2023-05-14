using System;

namespace SystemGreeting{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("My name is: " + name);
        }
    }
}
