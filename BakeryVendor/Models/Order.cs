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
  public DateTime TimeDateStamp { get; private set; }
  public int Id { get; private set; }

  private static List<Order> _order = new List<Order> {};

  DateTime todaysDate = DateTime.Now;

  public Order(string title, string description, double price)
  {
    Title = title;
    Description = description;
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

