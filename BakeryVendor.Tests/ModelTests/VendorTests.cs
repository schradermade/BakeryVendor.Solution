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

    [TestMethod]
    public void GetId_ReturnsVendorId_Id()
    {
      // Arrange
      string name = "Starbucks";
      string description = "coffee shop";
      Vendor newVendor = new Vendor(name, description);

      // Act
      int result = newVendor.Id;

      // Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void AssignId_ReturnsAssignedId_Id()
    {
      // Arrange
      string name = "Starbucks";
      string description = "coffee shop";
      Vendor newVendor0 = new Vendor(name, description);
      Vendor newVendor1 = new Vendor(name, description);
      Vendor newVendor2 = new Vendor(name, description);

      // Act
      int result0 = newVendor0.Id;
      int result1 = newVendor1.Id;
      int result2 = newVendor2.Id;

      // Assert
      Assert.AreEqual(1, result0);
      Assert.AreEqual(2, result1);
      Assert.AreEqual(3, result2);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_Vendors()
    {
      // Arrange
      string name = "Starbucks";
      string description = "coffee shop";
      Vendor newVendor0 = new Vendor(name, description);
      Vendor newVendor1 = new Vendor(name, description);
      Vendor newVendor2 = new Vendor(name, description);
      List<Vendor> newList = new List<Vendor> { newVendor0, newVendor1, newVendor2 };

      // Act
      List<Vendor> result = Vendor.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ClearAll_ReturnsClearedList_True()
    {
      // Arrange
      string name = "Starbucks";
      string description = "coffee shop";
      Vendor newVendor0 = new Vendor(name, description);
      Vendor newVendor1 = new Vendor(name, description);
      Vendor newVendor2 = new Vendor(name, description);
      List<Vendor> newList = new List<Vendor> { newVendor0, newVendor1, newVendor2 };
      Vendor.ClearAll();
      // Act
      List<Vendor> result = Vendor.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);

    }
  }
}