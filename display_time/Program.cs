// See https://aka.ms/new-console-template for more information
using System;

namespace SystemTime{
    class Program{
        static void Main(string[] args){
            DateTime localDate = DateTime.Now;
            System.Console.WriteLine("Date time is: " + localDate);
        }
    }
}
