using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;


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
    [TestMethod]
    public void CostBreadLessThen3_ReturnsBreadCost_Int()
    {
      int testRolls = 2;
      Bread testBread = new Bread(testRolls);
      int expectCost = 10;
      int resultCost = testBread.CarbCost();
      Assert.AreEqual(expectCost, resultCost);
    }
    [TestMethod]
    public void CostBreadRemainder2_ReturnsBreadCost_Int()
    {
      int testRolls = 5;
      Bread testBread = new Bread(testRolls);
      int expectCost = 20;
      int resultCost = testBread.CarbCost();
      Assert.AreEqual(expectCost, resultCost);
    }
    [TestMethod]
    public void CostBreademainder1_ReturnsBreadCost_Int()
    {
      int testRolls = 10;
      Bread testBread = new Bread(testRolls);
      int expectCost = 35;
      int resultCost = testBread.CarbCost();
      Assert.AreEqual(expectCost, resultCost);
    }
    
    
  }  
}
