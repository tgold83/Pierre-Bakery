using System;
using Bakery;

namespace CarbOrder
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");

      Console.WriteLine("would you like to hear about our deals? Enter yes or no:");
      string answer = Console.ReadLine();
      switch (answer) 
      {
        case "yes": 
          Console.WriteLine("We have some great deals for you! Bread is $5 a loaf or buy 2 get 1 free. Pastries are 1 for $2 and you get a dollar off for each third pastry purchased. If you get a dozen or more of either bread or pastries, you will get one free ($5 off for bread, $2 off for pastry)");
          break;
        case "Yes":
          Console.WriteLine("We have some great deals for you! Bread is $5 a loaf or buy 2 get 1 free. Pastries are 1 for $2 and you get a dollar off for each third pastry purchased. If you get a dozen or more of either bread or pastries, you will get one free ($5 off for bread, $2 off for pastry)");
          break;
        case "no":
          break;
        case "No":
          break;
        default:
          break;
      }

      Console.WriteLine("How many loaves of bread would you like? Enter a number:");
      int breadAmount = Int32.Parse(Console.ReadLine());
      Bread breadOrder = new Bread(breadAmount);
      Console.WriteLine("How many pastries would you like? Enter a number:");
      int pastryAmount = Int32.Parse(Console.ReadLine());
      Pastry pastryOrder = new Pastry(pastryAmount);
      int orderTotal = (breadOrder.Discount() + pastryOrder.Discount());
      Console.WriteLine("Your total is $" + orderTotal);
      
      Console.WriteLine("would you like to add to your order? Enter yes or no:");
      if (Console.ReadLine() == "yes" || Console.ReadLine() == "Yes")
      {
        Console.WriteLine("How many loaves of bread would you like to add to your order? Enter a number:");
        int addBread = Int32.Parse(Console.ReadLine());
        Bread addBreadOrder = new Bread(addBread);
        Console.WriteLine("How many pastries would you liketo add to your order? Enter a number:");
        int addPastry = Int32.Parse(Console.ReadLine());
        Pastry addPastryOrder = new Pastry(addPastry);
        int NewOrderTotal = ((addBreadOrder.Discount() + addPastryOrder.Discount()) + orderTotal);
        Console.WriteLine("Your new total is $" + NewOrderTotal);
      }
      else
      {
        Console.WriteLine("Your total is $" + orderTotal);
      }
    }
  }
}