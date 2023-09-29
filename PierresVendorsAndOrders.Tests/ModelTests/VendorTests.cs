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
  }
}