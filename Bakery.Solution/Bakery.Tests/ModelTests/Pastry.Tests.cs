using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_ReturnsAPastryObject_Pastry()
    {
      Pastry newPastry = new Pastry("Donut");
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void Buy_ReturnCostOfOnePastry_2()
    {
      Pastry testPastry = new Pastry("Donut");
      Assert.AreEqual(2, testPastry.Buy(1));
    }

    [TestMethod]
    public void Buy_ReturnCostOfThreePastries_5()
    {
      Pastry testPastry = new Pastry("Donut");
      Assert.AreEqual(5, testPastry.Buy(3));
    }

    [TestMethod]
    public void Buy_ReturnCostOfFourPastries_4()
    {
      Pastry testPastry = new Pastry("Donut");
      Assert.AreEqual(7, testPastry.Buy(4));
    }

    [TestMethod]
    public void Buy_ReturnCostOfFourteenPastries_24()
    {
      Pastry testPastry = new Pastry("Donut");
      Assert.AreEqual(24, testPastry.Buy(14));
    }
  }
}