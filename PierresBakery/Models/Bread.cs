using System;
using System.Collections.Generic;
using System.Linq;

namespace PierresBakery.Models
{
  public class Bread

  {
    private static List<Bread> _instances = new List<Bread> {};
    public int Loaves { get; set; }
    
    public Bread(int amount)
    {
        Loaves = amount;
        _instances.Add(this);
    }

    public static List<Bread> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    
  }
}  