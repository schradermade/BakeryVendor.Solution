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

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _vendors.Add(this);
      Id = AssignId();
    }
    public int AssignId()
    {
      int uniqueId = 0;
      for (int i = 1; i <= 100; i++)
        {
          if(_vendors.Exists(x => x.Id == i))
          {
          }
          else
          {
            return uniqueId += i;
          }
        }
        return uniqueId;
    }
    public static Vendor Find(int findId)
  {
    return _vendors[findId -1];
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