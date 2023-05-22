// See https://aka.ms/new-console-template for more information
using System;

namespace SystemTime{
    class Program{
        static void Main(string[] args){
            string localDate = DateTime.Now.ToString("dd'-'MM'-'yyy HH:mm:ss");
            System.Console.WriteLine("Date time is: " + localDate);
        }
    }
}
