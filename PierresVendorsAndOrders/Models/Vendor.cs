using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Features;

namespace PierresVendorsAndOrders.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public int Id { get; }
  }
}
