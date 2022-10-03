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

    [TestMethod]
    public void Bread_GetBakersDozenTotal_BakersDozen()
    {
      //Arrange
      int breadCount = 13;
      Bread breadOrder = new Bread(breadCount);
      int breadDeal;
      int bakersDozenBread;
      //Act
      bakersDozenBread = breadOrder.Discount();
      //Assert
      Assert.AreEqual(40, bakersDozenBread);
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_GetPastryCount_PastryCount()
    {
      //Arrange
      int pastryCount = 1;
      //Act
      Pastry pastryOrder = new Pastry(pastryCount);
      //Assert
      Assert.AreEqual(1, pastryOrder.PastryCount);
    }

    [TestMethod]
    public void Pastry_GetPastryTotal_Discount()
    {
      //Arrange
      int pastryCount = 3;
      Pastry pastryOrder = new Pastry(pastryCount);
      int pastryDeal;
      //Act
      pastryDeal = pastryOrder.Discount();
      //Assert
      Assert.AreEqual(5, pastryDeal);
    }

    [TestMethod]
    public void Pastry_GetBakersDozenTotal_BakersDozen()
    {
      //Arrange
      int pastryCount = 13;
      Pastry pastryOrder = new Pastry(pastryCount);
      int pastryDeal;
      int bakersDozenPastry;
      //Act
      bakersDozenPastry = pastryOrder.Discount();
      //Assert
      Assert.AreEqual(15, bakersDozenPastry);
    }
  }
}