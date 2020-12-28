using System.Collections.Generic;
using System;
using Bakery;

namespace Bakery.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }
    private static List<Vendor> _vendors = new List<Vendor> { };
    public List<Order> Orders { get; set; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _vendors.Add(this);
      Id = _vendors.Count;
      Orders = new List<Order> { };
    }
    public static Vendor Find(int findId)
  {
    return _vendors[findId -1];
  }
  public void AddOrder(Order order)
  {
    Orders.Add(order);
  }
    public static void DeleteVendor(int id)
  {
    _vendors.RemoveAll(r => r.Id == id);
  }
  public static void ClearAll()
  {
    _vendors.Clear();
  }
  public static List<Vendor> GetAll()
  {
    return _vendors;
  }

  }
}