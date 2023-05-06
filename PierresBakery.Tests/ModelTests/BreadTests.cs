using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;


namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable

  {
    public void Dispose()
    {
      Bread.ClearAll();
    }
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
    public void createInstanceList_ReturnList_List()
    {
      List<Bread> newList = new List<Bread> {};
      List<Bread> result = Bread.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    
  }  
}
