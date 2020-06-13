using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;

namespace hello2
{
    class Program
    {
        static int getUserChoice()
        {
            int userChoice;

            Console.WriteLine("***************WELCOME***************");
            Console.WriteLine("1.AQUAFINA---------5$");
            Console.WriteLine("2.COCA-------------7$");
            Console.WriteLine("3.SPRITE-----------7$");
            Console.WriteLine("4.NUTRIBOOST-------10$");
            Console.WriteLine("5.HEINEKEN---------10$");
            Console.WriteLine("6.POCA-------------5$");
            Console.WriteLine("7.WHISKEY----------20$");
            Console.WriteLine("*************************************");
            Console.WriteLine("Enter the number of product you want:");

            userChoice = int.Parse(Console.ReadLine());
            return userChoice;
        }
        static int getAmount()
        {
            Console.WriteLine("enter amount of product you want:");
            int amount = int.Parse(Console.ReadLine());
            return amount;

        }
        static bool isEnoughMoney()
        {
            return false;
        }
        static void Main(string[] args)
        {
            // enter user'money
            int userMoney = int.Parse(Console.ReadLine()); // user'Money : 100$
            int userChoice = getUserChoice();
            // create list of product 
            List<Drink> drinks = new List<Drink>();
            // Add drinks to the list.
            drinks.Add(new Drink("AQUAFINA", 5));
            drinks.Add(new Drink("COCA", 7));
            drinks.Add(new Drink("SPRITE", 7));

            foreach (var drink in drinks)
            {
                Console.WriteLine("drink name: {0}, drink price: {1}", drink.name, drink.price);
            }
            Console.ReadLine();
            switch (userChoice)
            {
                case 1:
                   int  amount = getAmount();
                    break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 5: break;
                case 6: break;
                case 7: break;
                default:
                    break;
            }

            
        }
    }
}
