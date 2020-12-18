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

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_True()
    {
      int newId = 5;
      DateTime date = Order.TimeDateStamp();
      Order newOrder = new Order(date, newId);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void AssignId_CreatesInstanceOfId_Id()
    {
      int newId = 5;
      DateTime date = Order.TimeDateStamp();
      Order newOrder = new Order(date, newId);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetId_CreatesUniqueIdForOrder_Int()
    { // Arrange
      int newId = 1;
      DateTime date = Order.TimeDateStamp();
      Order newOrder = new Order(date, newId);
      
      // Act
      int result = newOrder.Id;

      // Assert
      Assert.AreEqual(newId, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_True()
    {
      // Arrange
      int newId = 5;
      DateTime date = Order.TimeDateStamp();
      Order newOrder = new Order(date, newId);
      List<Order> newList = new List<Order> { };
      newList.Add(newOrder);
      Console.WriteLine(newList);

      // Act
      List<Order> result = Order.GetAll();
      Console.WriteLine(result);

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ClearAll_ClearsAllItems_True()
    {
      // Arrange
      DateTime date = Order.TimeDateStamp();
      Order newOrder0 = new Order(date, 5);
      Order newOrder1 = new Order(date, 5);
      List<Order> newList = new List<Order> { };

      // Act
      Order.ClearAll();
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetDate_ReturnTimeDateProperty_True()
    {
      // Arrange
      DateTime date = Order.TimeDateStamp();
      int newId = 5;
      Order newOrder = new Order(date, newId);
      // Act
      DateTime result = Order.TimeDateStamp();
      // Assert
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetPrice_ReturnsSetPrice_Price()
    {
      // Arrange
      int newId = 5;
      DateTime date = Order.TimeDateStamp();
      double price = 5;
      Order newOrder = new Order(date, newId);
      // Act
      double result = newOrder.Price;
      // Assert
      Assert.AreEqual(price, result);
    }

  }
}