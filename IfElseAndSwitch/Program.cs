using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseAndSwitch
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;

            if (hour > 0 && hour < 6)
                Console.WriteLine("it's night");
            else if (hour > 6 && hour < 12)
                Console.WriteLine("it's morning");
            else if (hour > 12 && hour < 18)
                Console.WriteLine("it's afternoon");
            else if (hour > 18 && hour < 24)
                Console.WriteLine("it's evening");

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("it's a beautiful season");
                    break;

                default:
                    Console.WriteLine("i don't understand this season");
                    break;
            }

            bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);
        }
    }
}
