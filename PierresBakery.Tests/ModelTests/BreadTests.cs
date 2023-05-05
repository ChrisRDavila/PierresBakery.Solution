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

    [TestMethod]
    public void SetBreadPrice_SetBreadPrice_Void()
    {
      //Arrange
      int test_cost = 5;
      Bread testBread = new Bread(5);
      //Act
      int result_cost = testBread.BreadPrice;
      //Assert
      Assert.AreEqual (test_cost, result_cost);
    }

    [TestMethod]
    public void GetUnitTypeForBread_ReturnsBreadChoice_String()
    {
      //Arrange
      int test_cost = 5;
      string test_type = "breadloaf";
      Bread testBread = new Bread(test_cost, "test_type");
      //Act
      string result_type = testBread.BreadChoice;
      //Assert
      Assert.AreEqual(test_type, result_type);
    }

  }
}
