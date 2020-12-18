using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery;
using System;

namespace Bakery.Test
{
  [TestClass]
  public class OrderTests
  {
    // public void Dispose()
    // {
    //   OrderTests.ClearAll();
    // }

    [TestMethod]
    public void GetOrder_CreatesInstanceOfItem_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}