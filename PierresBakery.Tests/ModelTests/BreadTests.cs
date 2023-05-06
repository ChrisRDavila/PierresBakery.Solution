using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;


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
      Bread newBread = new Bread(5);
      int result = newBread.Loaves;
      Assert.AreEqual(testAmount, result);

    }
    [TestMethod]
    public void SetBreadAmount_SetAmountValue_Int()
    {
      int testAmount = 5;
      Bread newBread = new Bread(5);
      int result = newBread.Loaves;
      Assert.AreEqual(testAmount, result);
    }
  }  
}
