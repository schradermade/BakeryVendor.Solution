using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Test
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_True()
    {
      // Arrange
      string name = "Starbucks";
      string description = "coffee shop";
      Vendor newVendor = new Vendor(name, description);

      // Assert
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
      

    }
  }
}