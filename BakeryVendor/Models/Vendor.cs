using System.Collections.Generic;
using System;
using Bakery;

namespace Bakery
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }

    private static List<Vendor> _vendors = new List<Vendor> { };

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _vendors.Add(this);
      Id = AssignId();
    }
  }
}