using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main() 
    {
      Bread bread = new Bread();
      Pastry pastry = new Pastry();

      Console.WriteLine("Welcome to the bakery!");
      int breadQuantity = int.Parse(GetInput("How much bread would you like? "));
      int pastryQuantity = int.Parse(GetInput("How many pastries would you like? "));

      Console.WriteLine($"That will cost ${bread.Buy(breadQuantity) + pastry.Buy(pastryQuantity)}");
      Console.WriteLine("Come again soon!");
    }

    private static string GetInput(string prompt)
    {
      Console.WriteLine(prompt);
      return Console.ReadLine();
    }
  }
}
