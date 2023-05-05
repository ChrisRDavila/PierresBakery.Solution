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
      Bread testBread = new Bread(1, "breadloaf");
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPrice_Int()
    {
        //Arrange
        int unit_cost = 5;
        Bread testBread = new Bread(5, "breadloaf");
        //Act
        int result_cost = testBread.BreadPrice;
        //Assert
        Assert.AreEqual(unit_cost, result_cost);
    }

    [TestMethod]
    public void SetBreadPrice_SetBreadPrice_Void()
    {
      //Arrange
      int unit_cost = 5;
      Bread testBread = new Bread(5, "breadlaof");
      //Act
      int result_cost = testBread.BreadPrice;
      //Assert
      Assert.AreEqual (unit_cost, result_cost);
    }

    [TestMethod]
    public void GetUnitTypeForBread_ReturnsBreadChoice_String()
    {
      //Arrange
      int unit_cost = 5;
      string unit_type = "breadloaf";
      Bread testBread = new Bread(unit_cost, unit_type);
      //Act
      string result_type = testBread.BreadChoice;
      //Assert
      Assert.AreEqual(unit_type, result_type);
    }

    [TestMethod]
    public void SetUnitTypeForBread_SetsBreadChoice_Void()
    {
      //Arrange
      int unit_cost = 5;
      string unit_type = "breadloaf";
      Bread testBread = new Bread(unit_cost, unit_type);
      //Act
      string result_type = testBread.BreadChoice;
      //Assert
      Assert.AreEqual(unit_type, result_type);
    }

    [TestMethod]
    public void GetAll_ReturnsAllBreadList_List()
    {
      //Arrange
      Bread unit1 = new Bread(5, "breadloaf");
      Bread unit2 = new Bread(5, "breadloaf");
      Bread unit3 = new Bread(0, "breadloaf");
      List<Bread> expectedResult = new List<Bread> {unit1, unit2, unit3};
      //Act
      List<Bread> actualResult = Bread.GetAll();
      //Assert
      CollectionAssert.AreEqual(expectedResult, actualResult);

    }
  }
}
