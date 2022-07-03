using System;
using System.Collections.Generic;
using Bakery.Models;

namespace PierresBakery
{
    public class Program 
    {
        public static List<string> userInput = new List<string>();
        public static void Main()
        {
            Bread bread = new Bread(0, 0);
            Pastry pastry = new Pastry(0,0);
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("Would you like to start with Bread (yes/no)?");
            string answerFirst = Console.ReadLine().ToLower();
            {
                if (answerFirst == "yes")
                {
                    Console.WriteLine("Bread deal of the week: 1 loaf: $5, but if you buy 2, you get 1 free! Please enter how much you want?");
                    string userInputBread = Console.ReadLine();
                    bread.Quant += int.Parse(userInputBread);
                    bread.Cost = Bread.BreadCost(bread.Quant);
                    Console.WriteLine("Good choice! Your total for this bread order is $" + bread.Cost);
                }
                else if (answerFirst == "no");
            }
            Console.WriteLine("Fantastic! Would you like to order any Pastries? (yes/no)");
            string secondAnswer = Console.ReadLine().ToLower();
            {
                if (secondAnswer == "yes")
                {
                    Console.WriteLine("Pasteries deal of the week: 1 pastry: $2, but if one buys 3, you can get them for a total of 5$! How many pastries would you like?");
                    string userInputPastry = Console.ReadLine();
                    pastry.Quant += int.Parse(userInputPastry);
                    pastry.Cost = Pastry.PastryCost(pastry.Quant);
                    Console.WriteLine("Nice choice! Your total for this pastry order is $" + pastry.Cost);
                }
                else if (secondAnswer == "no");
            }
            Console.WriteLine("Would you like anything else? If so type yes! If not, type 'done'!");
            string userAnswerFinal = Console.ReadLine().ToLower();
            if (userAnswerFinal == "yes")
            {
                Main();
            }
            else if (userAnswerFinal == "done")
            {
                int total = bread.Cost + pastry.Cost;
                Console.WriteLine(" Your total is: $" + total);
                Console.WriteLine("Thank you coming in!");
            }
            else
            {
                Console.WriteLine("Please enter a valid selection!");
            }
        }

    }
}