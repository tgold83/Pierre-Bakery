using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_GetBreadCount_BreadCount()
    {
      //Arrange
      int breadCount = 1;
      //Act
      Bread breadOrder = new Bread(breadCount);
      //Assert
      Assert.AreEqual(1, breadOrder.BreadCount);
    }

    [TestMethod]
    public void Bread_GetBreadCountDividedBy3_Discount()
    {
      //Arrange
      int breadCount = 8;
      Bread breadOrder = new Bread(breadCount);
      int breadDeal;
      //Act
      breadDeal = breadOrder.Discount();
      //Assert
      Assert.AreEqual(2, breadDeal);
    }

    [TestMethod]
    public void Bread_GetBreadTotal_Discount()
    {
      //Arrange
      int breadCount = 3;
      Bread breadOrder = new Bread(breadCount);
      int breadDeal;
      //Act
      breadDeal = breadOrder.Discount();
      //Assert
      Assert.AreEqual(10, breadDeal);
    }
  }
}