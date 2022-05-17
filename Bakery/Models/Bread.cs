using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread : BakedGood
  {
    private const int DefaultCost = 5;

    public Bread(string name) : base(name, DefaultCost) {}

    public override int Buy(int amount)
    {
      return (amount - (amount / 3)) * base.Cost;
    }
  }
}
