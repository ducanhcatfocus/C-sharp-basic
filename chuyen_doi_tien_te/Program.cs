using System;

namespace SystemMoneyConvert{
    class Program{
        static void Main(string[] args){
            int rate = 23000;
            float usd;
            Console.WriteLine("Enter USD: ");
             usd = float.Parse(Console.ReadLine());
            Console.WriteLine(usd + " USD = " + usd * rate + " VND");
        }
    }
}
