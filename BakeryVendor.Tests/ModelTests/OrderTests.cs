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
      string title = "Starbucks";
      double price = 10;
      // DateTime date = Order.TimeDateStamp();
      Order newOrder = new Order(title, price);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void AssignId_CreatesInstanceOfId_Id()
    {
      string title = "Starbucks";
      double price = 10;
      // DateTime date = Order.TimeDateStamp();
      Order newOrder = new Order(title, price);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetId_CreatesUniqueIdForOrder_Int()
    { // Arrange
      string title = "Starbucks";
      double price = 10;
      // DateTime date = Order.TimeDateStamp();
      Order newOrder = new Order(title, price);
      
      // Act
      int result = newOrder.Id;

      // Assert
      Assert.AreEqual(newOrder.Id, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_True()
    {
      // Arrange
      string title = "Starbucks";
      double price = 10;
      // DateTime date = Order.TimeDateStamp();
      Order newOrder = new Order(title, price);
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
      string title = "Starbucks";
      double price = 10;
      // DateTime date = Order.TimeDateStamp();
      Order newOrder0 = new Order(title, price);
      Order newOrder1 = new Order(title, price);
      List<Order> newList = new List<Order> { };

      // Act
      Order.ClearAll();
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    // [TestMethod]
    // public void TimeDateStamp_ReturnTimeDateProperty_True()
    // {
    //   // Arrange
    //   // DateTime date = Order.TimeDateStamp();
    //   int newId = 5;
    //   string title = "Starbucks";
    //   Order newOrder = new Order(title, newId);
    //   // Act
    //   ;
    //   // Assert
    //   Assert.AreEqual(title, result);
    // }

    [TestMethod]
    public void SetPrice_ReturnsSetPrice_Price()
    {
      // Arrange
      string title = "Starbucks";
      double price = 10;
      // DateTime date = Order.TimeDateStamp();
      Order newOrder = new Order(title, price);
      // Act
      double result = newOrder.Price;
      // Assert
      Assert.AreEqual(result, newOrder.Price);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Price()
    {
      // Arrange
      string title = "Starbucks";
      double price = 10;
      // DateTime date = Order.TimeDateStamp();
      Order newOrder = new Order(title, price);
      // Act
      double result = newOrder.Price;
      // Assert
      Assert.AreEqual(result, newOrder.Price);
    }

  }
}