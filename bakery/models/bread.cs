using System;

namespace Bakery.Models
{
    public class Bread
    {
        public int Cost { get; set; }
        public int Quant { get; set; }
        
        public Bread(int cost, int quant)
        {
            Cost = cost;
            Quant = quant;
        }
        public static int BreadCost(int quant)
        {
            int newQuant = quant % 3;
            int total = newQuant * 5;
            if (quant > 2)
            {
                int deal = quant / 3;
                total += deal * 10;
            }
            return total;
        }
    }
} 