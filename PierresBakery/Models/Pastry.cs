using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryPrice{ get; set; }
    public string PastryChoice{ get; set; }

    private static List<Pastry> orders_bread = new List<Pastry> {};

    public Pastry(int unit_cost, string unit_type)
    {
      PastryPrice = unit_cost;
      PastryChoice = unit_type;
      orders_bread.Add(this);
    }
  }
} 