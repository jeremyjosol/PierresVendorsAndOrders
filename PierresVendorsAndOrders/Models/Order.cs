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
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}