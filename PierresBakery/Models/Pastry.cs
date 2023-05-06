using System;
using System.Collections.Generic;


namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Rolls { get;}

    private int roll_cost = 0;
    public Pastry(int _amount)
    {
      Rolls = _amount;
    }

    public int RollCost()
    {
      if(Rolls % 4 == 0)
      {
        roll_cost = ((Rolls -(Rolls / 4)) * 2);
      }
      return roll_cost;
    } 
  }
} 