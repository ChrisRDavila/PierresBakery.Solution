using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
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
    public void GetBreadPrice_ReturnsBreadPrice_Int()
    {
        //Arrange
        int test_cost = 5;
        Bread testBread = new Bread(5);
        //Act
        int result_cost = testBread.BreadPrice;
        //Assert
        Assert.AreEqual(test_cost, result_cost);
    }
  }
}
