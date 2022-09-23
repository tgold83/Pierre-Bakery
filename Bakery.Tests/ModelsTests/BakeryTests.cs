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
  }
}