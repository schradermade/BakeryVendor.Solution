using System.Collections.Generic;
using System;
using Bakery;

namespace Bakery
{
  public class Order
  {
  
  public string Title { get; private set; }
  public double Price { get; private set; }
  public int Id { get; private set; }
  public DateTime TimeDateStamp { get; private set; }

  private static List<Order> _order = new List<Order> {};

  DateTime todaysDate = DateTime.Now;

  public Order(string title, double price)
  {
    Title = title;
    Price = price;
    _order.Add(this);
    Id = AssignId();
  }

  public int AssignId()
  {
    int uniqueId = 0;
    for (int i = 1; i <= 100; i++)
      {
        if(_order.Exists(x => x.Id == i))
        {
        }
        else
        {
          return uniqueId += i;
        }
      }
      return uniqueId;
  }

  public static List<Order> GetAll()
  {
    return _order;
  }

  public static void ClearAll()
  {
    _order.Clear();
  }
  
  //   public static DateTime TimeDateStamp()
  // {
  //   return DateStamp.todaysDate;
  // }

  }
}

