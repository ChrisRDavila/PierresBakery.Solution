using System;
using System.Collections.Generic;
using System.Linq;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Loaves { get; set; }
    
    public Bread(int amount)
    {
        Loaves = amount;
    }
    
  }
}  