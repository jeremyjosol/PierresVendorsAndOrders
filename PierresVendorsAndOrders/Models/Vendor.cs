using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Features;

namespace PierresVendorsAndOrders.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    public string Description { get; set; }

    public Vendor(string businessName)
    {
      Name = businessName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }
    public Vendor(string businessName, string businessDescription)
    {
      Name = businessName;
      Description = businessDescription;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public void AddOrder(Order productName)
    {
      Orders.Add(productName);
    }
    public void ClearOrders()
    {
      Orders.Clear();
    }
  }
}
