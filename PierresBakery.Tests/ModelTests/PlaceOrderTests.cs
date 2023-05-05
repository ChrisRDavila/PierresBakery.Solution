using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PlaceOrder.Tests
{
  [TestClass]
  public class PlaceOrderTests
  {
    public void GetLists_GetBothLists_Lists()
    {
      //Arrange
      Bread newBread = new Bread(5, "breadloaf");
      List<Bread> breadList = new List<Bread> {newBread};
      Pastry newPastry = new Pastry(2, "pastry");
      List<Pastry> pastryList = new List<Pastry> {newPastry};
      //Act
      

    }
  }
}