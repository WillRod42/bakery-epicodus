using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  abstract public class BakedGood
  {
    public string Name { get; }
    public int Cost { get; set; }

    public BakedGood(string name)
    {
      Name = name;
    }

    public BakedGood(string name, int cost)
    {
      Cost = cost;
      Name = name;
    }

    public virtual int Buy(int amount)
    {
      return amount * Cost;
    }
  }
}
