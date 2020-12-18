using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery;
using System;

namespace Bakery.Test
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    // [TestMethod]
    // public void OrderConstructor_CreatesInstanceOfOrder_True()
    // {
    //   Order newOrder = new Order(date);
    //   Assert.AreEqual(typeof(Order), newOrder.GetType());
    // }

    // [TestMethod]
    // public void AssignId_CreatesInstanceOfId_Id()
    // {
    //   Order newOrder = new Order(date);
    //   Assert.AreEqual(typeof(Order), newOrder.GetType());
    // }

    // [TestMethod]
    // public void GetId_CreatesUniqueIdForOrder_Id()
    // {
    //   Order newOrder = new Order(date);
    //   Assert.AreEqual(2, newOrder.AssignId());
    // }

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_True()
    // {
    //   // Arrange
    //   List<Order> newList = new List<Order> { };
    //   Order newOrder = new Order();
    //   newList.Add(newOrder);
    //   Console.WriteLine(newList);
    //   // Act
    //   List<Order> result = Order.GetAll();
    //   Console.WriteLine(result);
    //   // Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void ClearAll_ClearsAllItems_True()
    // {
    //   // Arrange
    //   Order newOrder0 = new Order(date);
    //   Order newOrder1 = new Order(date);
    //   List<Order> newList = new List<Order> { };

    //   // Act
    //   Order.ClearAll();
    //   List<Order> result = Order.GetAll();

    //   // Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    [TestMethod]
    public void GetDate_ReturnTimeDateProperty_True()
    {
      // Arrange
      DateTime date = new DateTime(2021, 12, 18);
      Order newOrder = new Order(date);
      // Act
      DateTime result = Order.TimeDateStamp();
      // Assert
      Assert.AreEqual(date, result);
    }

  }
}