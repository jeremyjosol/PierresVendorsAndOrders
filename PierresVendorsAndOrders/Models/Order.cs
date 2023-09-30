using System.Collections.Generic;

namespace PierresVendorsAndOrders.Models
{
  public class Order
  {
    public string Product { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Date { get; set; }

    public Order(string product)
    {
      Product = product;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public Order(string product, string productDescription, decimal productPrice, string orderDate)
    {
      Product = product;
      Description = productDescription;
      Price = productPrice;
      Date = orderDate;
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