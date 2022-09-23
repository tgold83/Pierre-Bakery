using System;
using Bakery;

namespace CarbOrder
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Bread is $5 a loaf or buy 2 get 1 free. Pastries are 1 for $2 and you get a dollar off for each third pastry purchased.");
      Console.WriteLine("How many loaves of bread would you like? Enter a number:");
      int breadAmount = Int32.Parse(Console.ReadLine());
      Bread breadOrder = new Bread(breadAmount);
      Console.WriteLine("How many pastries would you like? Enter a number:");
      int pastryAmount = Int32.Parse(Console.ReadLine());
      Pastry pastryOrder = new Pastry(pastryAmount);
      int orderTotal = (breadOrder.Discount() + pastryOrder.Discount());
      Console.WriteLine("Your total is $" + orderTotal);
    }
  }
}