using System;

namespace Bakery.Models
{
    public class Pastry
    {
        public int Cost { get; set; }
        public int Quant { get; set; }

        public Pastry(int cost, int quant)
        {
            Cost = cost;
            Quant = quant;
        }
        public static int PastryCost(int quant)
        {
            int newQuant = quant % 3;
            int total = newQuant * 2;
            if (quant > 2)
            {
                int deal = quant / 3; 
                total += deal * 5;
            }
            return total;
        }

    }
} 