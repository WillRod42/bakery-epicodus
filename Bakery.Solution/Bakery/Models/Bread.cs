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
  }
}
