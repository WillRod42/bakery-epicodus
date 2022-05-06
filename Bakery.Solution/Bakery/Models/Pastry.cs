using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public Dictionary<int, int> Deals { get; set; }
    private static Dictionary<int, int> _defaultDeals = new Dictionary<int, int>
    {
      {6, 10},
      {5, 9},
      {4, 7},
      {3, 5},
      {1, 2}
    };

    public Pastry(Dictionary<int, int> deals) 
    {
      Deals = new Dictionary<int, int>(deals);
    }

    public Pastry() : this(_defaultDeals) {}

    public int Buy(int amount)
    {
      int cost = 0;
      foreach (int quantity in Deals.Keys)
      {
        if (amount < 0)
        {
          break;
        }
        int dealAmount = amount / quantity;
        cost += dealAmount * Deals[quantity];
        amount -= quantity * dealAmount;
      }

      return cost;
    }
  }
}
