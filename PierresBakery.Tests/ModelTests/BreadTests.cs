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
      Bread testBread = new Bread();
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }

    public void GetBreadPrice_ReturnPrice_Int()
    {
      //Arrange
      int breadPrice = 5;
      Bread testBread = new Bread(breadPrice);
      //Act
      int result = testBread.BreadPrice;
      //Assert
      Assert.AreEqual(breadPrice, result);
    }
  }
}
