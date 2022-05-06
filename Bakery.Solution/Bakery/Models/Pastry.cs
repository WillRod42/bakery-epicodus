using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public Dictionary<int, int> Deals { get; set; }
    private const Dictionary<int, int> DefaultDeals = new Dictionary<int, int>
    {
      {1, 2},
      {3, 5},
      {4, 7},
      {5, 9},
      {6, 10}
    };

    public Pastry(Dictionary<int, int> deals) 
    {
      Deals = new Dictionary<int, int>(deals);
    }

    public Pastry() : this(DefaultDeals) {}

    
  }
}
