using System.Collections.Generic;

namespace PierresVendorsAndOrders.Models
{
  public class Order
  {
    public string Product { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string product)
    {
      Product = product;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}