using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Cost { get; set; }
    private const int DefaultCost = 5;

    public Bread(int cost)
    {
      Cost = cost;
    }

    public Bread() : this(DefaultCost) {}

    public int Buy(int amount)
    {
      return (amount - (amount / 3)) * Cost;
    }
  }
}
