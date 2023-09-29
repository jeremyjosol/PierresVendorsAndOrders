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
    [TestMethod]
    public void GetAll_ReturnsAllSongObjects_OrderList()
    {
      string productName01 = "Croissant";
      string productName02 = "Baguette";
      Order newOrder1 = new Order(productName01);
      Order newOrder2 = new Order(productName02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_SongsInstantiateWithAnIdAndGetterReturns_Int()
    {
      string productName = "Croissant";
      Order newOrder = new Order(productName);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
  }
}