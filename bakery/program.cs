using System;
using BreadBakery.Models;
using PastryBakery.Models;

namespace PierresBakery
{
    public class Program 
    {
        public static List<string> userInput = new List<string>();
        public static void Main()
        {
            Bread bread = new Bread(0, 0);
            Pastry pastry = new Pastry(0,0);

            Console.WriteLine("Welcome to Pierre's Bakery. There are plenty of delicious treats to choose from. What can we get for you? For breads(press B),pastry(press P) or combination(press C) or none(Type no)?");
            string userInput = Console.ReadLine().ToLower();
            string answer = Console.ReadLine();
            if (answer == "B" || answer == "b")
            {
                Console.WriteLine("Deal of the week: 1 loaf: $5, but if you buy 2, you get 1 free! Please enter how many you would like!");
                string userInputBread = Console.ReadLine();
                bread.Quant += int.Parse(userInputBread);
                bread.Cost = Bread.BreadCost(bread.Quant);
                Console.WriteLine("Fantastic! Your total order is $" + bread.Cost);

            }else if( answer == "No" || answer == "no" || answer == "NO")
            {
            Console.WriteLine("Have a nice day and come back again!"); 
            }

        }  
    }

    }