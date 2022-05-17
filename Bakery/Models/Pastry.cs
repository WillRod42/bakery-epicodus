using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry : BakedGood
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

    public Pastry(string name, Dictionary<int, int> deals) : base(name)
    {
      Deals = new Dictionary<int, int>(deals);
    }

    public Pastry(string name) : this(name, _defaultDeals) {}

    public override int Buy(int amount)
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
