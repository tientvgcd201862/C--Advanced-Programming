using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm4
{
    internal class Program
    {
        class PriceCalculator
        {
            public enum Season
            {
                Spring = 4,
                Summer = 1,
                Autumn = 2,
                Winter = 3
            }

            public enum Discount
            {
                None = 0,
                SecondVisit = 10,
                VIP = 20
            }

            public static double CalculateTotalPrice(double pricePerDay, int numberOfDays, Season season, Discount discount)
            {
                double seasonMultiplier = (double)season;
                double totalPrice = pricePerDay * numberOfDays * seasonMultiplier;
                double discountType = (double)discount / 100;
                return totalPrice - (totalPrice * discountType);
            }

        }

        static void Main(string[] args)
        {
            double pricePerDay = 200;
            int numberOfDays = 7;
            PriceCalculator.Season season = PriceCalculator.Season.Summer;
            PriceCalculator.Discount discount = PriceCalculator.Discount.VIP;

            double totalPrice = PriceCalculator.CalculateTotalPrice(pricePerDay, numberOfDays, season, discount);
            Console.WriteLine("Total Price: " + totalPrice);
            
        }
    }
}
