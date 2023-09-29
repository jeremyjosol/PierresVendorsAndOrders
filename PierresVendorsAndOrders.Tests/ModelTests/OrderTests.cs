using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendorsAndOrders.Models;
using System;

namespace PierresVendorsAndOrders.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string productName = "Croissant";
      Order newOrder = new Order(productName);
      string result = newOrder.Product;
      Assert.AreEqual(productName, result);
    }
  }
}