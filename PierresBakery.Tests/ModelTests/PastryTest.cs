using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearAll();
    }
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry testPastry = new Pastry(2, "pastry");
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }

    [TestMethod]
    public void GetPastryPrice_ReturnsPastryPrice_Int()
    {
        //Arrange
        int unit_cost = 2;
        Pastry testPastry = new Pastry(2, "pastry");
        //Act
        int result_cost = testPastry.PastryPrice;
        //Assert
        Assert.AreEqual(unit_cost, result_cost);
    }

    [TestMethod]
    public void GetUnitTypeForPastry_ReturnsPastryChoice_String()
    {
      //Arrange
      int unit_cost = 2;
      string unit_type = "pastry";
      Pastry testPastry = new Pastry(unit_cost, unit_type);
      //Act
      string result_type = testPastry.PastryChoice;
      //Assert
      Assert.AreEqual(unit_type, result_type);
    }

    [TestMethod]
    public void GetAll_ReturnsAllPastryList_List()
    {
      //Arrange
      Pastry unit1 = new Pastry(2, "pastry");
      Pastry unit2 = new Pastry(2, "pastry");
      Pastry unit3 = new Pastry(2, "pastry");
      Pastry unit4 = new Pastry(0, "pastry");
      List<Pastry> expectedResult = new List<Pastry> {unit1, unit2, unit3, unit4};
      //Act
      List<Pastry> actualResult = Pastry.GetAll();
      //Assert
      CollectionAssert.AreEqual(expectedResult, actualResult);
    }

  }
}