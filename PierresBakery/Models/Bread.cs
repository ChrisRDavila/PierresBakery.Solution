using System;
using System.Collections.Generic;
using System.Linq;

namespace PierresBakery.Models
{
  public class Bread

  {
    public int Loaves { get; set; }
    private int current_cost = 0;
    
    public Bread(int _amount)
    {
      Loaves = _amount;
    }
    
    public int CarbCost()
    { 
      if(Loaves % 3 == 0)
      {
        current_cost = (Loaves - ((Loaves / 3))) * 5;
      }
      else if (Loaves < 3)
      {
        current_cost =  Loaves * 5;
      }
      else  
      {
        if ((Loaves - 1) % 3 == 0) 
        {
          current_cost = (5 * (Loaves - 1)) - ((Loaves/3) * 5) + 5;
        }
        else
        {
          current_cost = (5 * (Loaves - 2)) - ((Loaves / 3) * 5) + 10;
        }
      } 
      return current_cost;
  
    }
    
  }
    
}
  