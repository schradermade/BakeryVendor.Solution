using System.Collections.Generic;
using System;
using Bakery;

namespace Bakery.Models
{
  public class Order
  {
  
  public string Title { get; private set; }
  public string Description { get; private set; }
  public double Price { get; private set; }
  public string Date { get; set; }
  public int Id { get; set; }

  public int VendorId { get;set;}

  private static List<Order> _order = new List<Order> {};

  public Order(int vendorId, string title, string description, double price, string date)
  {
    VendorId = vendorId;
    Title = title;
    Description = description;
    Price = price;
    Date = date;
    _order.Add(this);
    Id = _order.Count;
  }

  public static List<Order> GetAll()
  {
    return _order;
  }

  public static void ClearAll()
  {
    _order.Clear();
  }

  public static Order Find(int findId)
  {
    return _order[findId -1];
  }

  public static void DeleteOrder(int id)
  {
    _order.RemoveAll(r => r.Id == id);
  }
  
  //   public static DateTime TimeDateStamp()
  // {
  //   return DateStamp.todaysDate;
  // }

  }
}

