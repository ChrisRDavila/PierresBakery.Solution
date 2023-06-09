using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;


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
    [TestMethod]
    public void CostPastryLessThen4_ReturnsPastryCost_Int()
    {
      int testRolls = 13;
      Pastry testPastry = new Pastry(testRolls);
      int expectCost = 20;
      int resultCost = testPastry.RollCost();
      Assert.AreEqual(expectCost, resultCost);
    }
    [TestMethod]
    public void CostPastryModulo1_ReturnsPastryCost_Int()
    {
      int testRolls = 5;
      Pastry testPastry = new Pastry(testRolls);
      int expectCost = 8;
      int resultCost = testPastry.RollCost();
      Assert.AreEqual(expectCost, resultCost);
    }
    [TestMethod]
    public void CostPastryModulo2_ReturnsPastryCost_Int()
    {
      int testRolls = 14;
      Pastry testPastry = new Pastry(testRolls);
      int expectCost = 22;
      int resultCost = testPastry.RollCost();
      Assert.AreEqual(expectCost, resultCost);
    }
    [TestMethod]
    public void CostPastryModulo3_ReturnsPastryCost_Int()
    {
      int testRolls = 15;
      Pastry testPastry = new Pastry(testRolls);
      int expectCost = 24;
      int resultCost = testPastry.RollCost();
      Assert.AreEqual(expectCost, resultCost);
    }

  }
}    
