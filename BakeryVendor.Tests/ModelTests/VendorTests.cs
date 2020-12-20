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

    [TestMethod]
    public void NameProperty_SetsNameProperty_Name()
    {
      // Arrange
      string name = "Starbucks";
      string description = "coffee shop";
      Vendor newVendor = new Vendor(name, description);

      // Act
      string result = newVendor.Name;

      // Assert
      Assert.AreEqual("Starbucks", result);
    }

    [TestMethod]
    public void DescriptionProperty_SetsDescriptProperty_Description()
    {
      // Arrange
      string name = "Starbucks";
      string description = "coffee shop";
      Vendor newVendor = new Vendor(name, description);

      // Act
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual("coffee shop", result);

    }
  }
}