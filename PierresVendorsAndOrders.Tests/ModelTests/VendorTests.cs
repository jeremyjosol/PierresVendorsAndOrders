using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendorsAndOrders.Models;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;

namespace PierresVendorsAndOrders.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      string businessName = "St. Honoré";
      Vendor newVendor = new Vendor(businessName);
      string result = newVendor.Name;
      Assert.AreEqual(businessName, result);
    }
    [TestMethod]
    public void VendorId_ReturnsVendorId_Int()
    {
      string businessName = "St. Honoré";
      Vendor newVendor = new Vendor(businessName);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string businessName01 = "St. Honoré";
      string businessName02 = "La Provence";
      Vendor newVendor1 = new Vendor(businessName01);
      Vendor newVendor2 = new Vendor(businessName02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string businessName01 = "St. Honoré";
      string businessName02 = "La Provence";
      Vendor newVendor1 = new Vendor(businessName01);
      Vendor newVendor2 = new Vendor(businessName02);
      Vendor result = Vendor.Find(1);
      Vendor result2 = Vendor.Find(2);
      Assert.AreEqual(newVendor1, result);
      Assert.AreEqual(newVendor2, result2);
    }
    [TestMethod]
    public void AddOrder_EstablishesRelationshipWithVendor_OrderList()
    {
      string productName = "Croissant";
      Order newOrder = new Order(productName);
      List<Order> newList = new List<Order> { newOrder };
      string vendorName = "St. Honoré";
      Vendor newVendor = new Vendor(vendorName);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}