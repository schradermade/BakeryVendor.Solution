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
    public void GetOrder_CreatesInstanceOfItem_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void AssignId_CreatesInstanceOfId_Id()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Bread), newOrder.GetType());
    }

    // [TestMethod]
    // public void GetId_CreatesUniqueIdForOrder_Id()
    // {
    //   Order newOrder = new Order();
    //   Assert.AreEqual(1, newOrder.GetId());
    // }

  }
}