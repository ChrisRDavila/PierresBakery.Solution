using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTest
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry testPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }
    [TestMethod]
    public void GetPastryAmount_ReturnsPastryAmount_Int()
    {
      int testAmount = 5;
      Pastry testPastry = new Pastry(5);
      int result = testPastry.Rolls;
      Assert.AreEqual(testAmount, result);
    }
    [TestMethod]
    public void SetPastryAmount_SetPastryValue_Int()
    {
      int testAmount = 5;
      Pastry testPastry = new Pastry(5);
      int result = testPastry.Rolls;
      Assert.AreEqual(testAmount, result);
    }
    [TestMethod]
    public void CostBreadDivisibleBy4_ReturnsPastryCost_Int()
    {
      int testAmount = 8;
      Pastry testPastry = new Pastry(testAmount);
      int expectCost = 12;
      int resultCost = testPastry.RollCost();
      Assert.AreEqual(expectCost, resultCost);
    }

  }
}    
