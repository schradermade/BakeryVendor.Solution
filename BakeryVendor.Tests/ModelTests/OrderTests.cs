using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
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
      string description = "100 Cheese bagels";
      double price = 10;
      string date = "11/25/2020";
      int vendorId = 1;
      // DateTime date = Order.TimeDateStamp();
      Order newOrder = new Order(vendorId, title, description, price, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void AssignId_CreatesInstanceOfId_Id()
    {
      string title = "Starbucks";
      string description = "100 Cheese bagels";
      double price = 10;
      string date = "11/25/2020";
      int vendorId = 1;
      // DateTime date = Order.TimeDateStamp();
      Order newOrder = new Order(vendorId, title, description, price, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetId_CreatesUniqueIdForOrder_Int()
    { // Arrange
      string title = "Starbucks";
      string description = "100 Cheese bagels";
      double price = 10;
      string date = "11/25/2020";
      int vendorId = 1;
      // DateTime date = Order.TimeDateStamp();
      Order newOrder = new Order(vendorId, title, description, price, date);
      
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
      string description = "100 Cheese bagels";
      double price = 10;
      string date = "11/25/2020";
      int vendorId = 1;
      Order newOrder = new Order(vendorId, title, description, price, date);
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
      string description = "100 Cheese bagels";
      double price = 10;
      string date = "11/25/2020";
      int vendorId0 = 1;
      int vendorId1 = 2;
      Order newOrder0 = new Order(vendorId0, title, description, price, date);
      Order newOrder1 = new Order(vendorId1, title, description, price, date);
      List<Order> newList = new List<Order> { };

      // Act
      Order.ClearAll();
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void SetPrice_ReturnsSetPrice_Price()
    {
      // Arrange
      string title = "Starbucks";
      string description = "100 Cheese bagels";
      double price = 10;
      string date = "11/25/2020";
      int vendorId = 1;
      Order newOrder = new Order(vendorId, title, description, price, date);
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
      string description = "100 Cheese bagels";
      double price = 10;
      string date = "11/25/2020";
      int vendorId = 1;
      Order newOrder = new Order(vendorId, title, description, price, date);
      // Act
      double result = newOrder.Price;
      // Assert
      Assert.AreEqual(result, newOrder.Price);
    }

    [TestMethod]
    public void Find_ReturnsOrderById_Order()
    {
      // Arrange
      string title0 = "Starbucks";
      string description0 = "100 Cheese bagels";
      double price0 = 10;
      string date0 = "11/25/2020";
      int vendorId0 = 1;
      string title1 = "Starbucks";
      string description1 = "100 Cheese bagels";
      double price1 = 10;
      string date1 = "11/25/2020";
      int vendorId1 = 2;
      Order newOrder0 = new Order(vendorId0, title0, description0, price0, date0);
      Order newOrder1 = new Order(vendorId1, title1, description1, price1, date1);
      // Act
      Order result = Order.Find(1);

      // Assert
      Assert.AreEqual(newOrder0, result);
    }

    [TestMethod]
    public void DeleteOrder_ReturnsEmptyList_True()
    {
      // Arrange
      string title0 = "Starbucks";
      string description0 = "100 Cheese bagels";
      double price0 = 10;
      string date0 = "11/25/2020";
      int vendorId0 = 1;
      string title1 = "Starbucks";
      string description1 = "100 Cheese bagels";
      double price1 = 10;
      string date1 = "11/25/2020";
      int vendorId1 = 1;
      Order newOrder0 = new Order(vendorId0, title0, description0, price0, date0);
      Order newOrder1 = new Order(vendorId1, title1, description1, price1, date1);
      List<Order> newList = new List<Order> { newOrder0, newOrder1 };
      
      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void SetDescription_ReturnsDescription_String()
    {
      // Arrange
      string title = "Bagels";
      string description = "100 Cheese bagels";
      double price = 10;
      string date = "11/25/2020";
      int vendorId = 1;
      Order newOrder = new Order(vendorId, title, description, price, date);

      // Act
      string result = newOrder.Description;

      // Assert
      Assert.AreEqual("100 Cheese bagels", result);
    }

    [TestMethod]
    public void VendorIdProperty_ReturnsVendorId_Int()
    {
      // Arrange
      string title = "Bagels";
      string description = "100 Cheese bagels";
      double price = 10;
      string date = "11/25/2020";
      int vendorId = 1;
      Order newOrder = new Order(vendorId, title, description, price, date);

      // Act
      int result = newOrder.VendorId;

      // Assert
      Assert.AreEqual(1, result);
    }
  }
}