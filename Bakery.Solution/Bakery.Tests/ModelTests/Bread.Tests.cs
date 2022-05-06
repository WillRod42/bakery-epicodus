using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_ReturnsABreadObject_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void Buy_ReturnCostOfBread_15()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(15, testBread.Buy(4));
    }
  }
}
