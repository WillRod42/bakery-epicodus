using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main() 
    {
      Dictionary<BakedGood, int> goodsAndQuantities = new Dictionary<BakedGood, int>()
      {
        {new Bread("Baguettes"), 0},
        {new Pastry("Donuts"), 0}
      };

      int totalCost = 0;
      Console.WriteLine("Welcome to the bakery!");
      foreach (BakedGood good in goodsAndQuantities.Keys)
      {
        int quantity = int.Parse(GetInput($"How many {good.Name} would you like? "));
        goodsAndQuantities[good] = quantity;
        totalCost += good.Buy(quantity);
      }

      Console.WriteLine($"That will cost ${totalCost}");
      Console.WriteLine("Come again soon!");
    }

    private static string GetInput(string prompt)
    {
      Console.WriteLine(prompt);
      return Console.ReadLine();
    }
  }
}
