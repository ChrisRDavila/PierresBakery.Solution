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

  }
}    
