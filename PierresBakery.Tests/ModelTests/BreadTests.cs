using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;


namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests

  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread testBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }

    [TestMethod]
    public void GetBreadAmount_ReturnsBreadAmount_Int()
    {
      int testAmount = 5;
      Bread testBread = new Bread(5);
      int result = testBread.Loaves;
      Assert.AreEqual(testAmount, result);

    }
    
    [TestMethod]
    public void SetBreadAmount_SetAmountValue_Int()
    {
      int testAmount = 5;
      Bread testBread = new Bread(5);
      int result = testBread.Loaves;
      Assert.AreEqual(testAmount, result);
    }
    
    [TestMethod]
    public void CostBreadDivisibleBy3_ReturnsBreadCost_Int()
    {
      int testRolls = 9;
      Bread testBread = new Bread(testRolls);
      int expectCost = 30;
      int resultCost = testBread.CarbCost();
      Assert.AreEqual(expectCost, resultCost);
    }
    
    
  }  
}
