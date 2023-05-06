using System;
using System.Collections.Generic;
using System.Linq;

namespace PierresBakery.Models
{
  public class Bread

  {
    public int Loaves { get; set; }
    private int loaf_cost = 0;
    
    public Bread(int _amount)
    {
      Loaves = _amount;
    }
    
    public int CarbCost()
    { 
      if(Loaves % 3 == 0)
      {
        loaf_cost = (Loaves - ((Loaves / 3))) * 5;
      }
      else if (Loaves < 3)
      {
        loaf_cost =  Loaves * 5;
      }
      else  
      {
        if ((Loaves - 1) % 3 == 0) 
        {
          loaf_cost = (5 * (Loaves - 1)) - ((Loaves/3) * 5) + 5;
        }
        else
        {
          loaf_cost = (5 * (Loaves - 2)) - ((Loaves / 3) * 5) + 10;
        }
      } 
      return loaf_cost;
  
    }
    
  }
    
}
  