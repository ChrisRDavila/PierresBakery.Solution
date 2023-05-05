using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadPrice{ get; set; }
    public string BreadChoice{ get; set; }

    private static List<Bread> orders_bread = new List<Bread> {};

    public Bread(int unit_cost, string unit_type)
    {
      BreadPrice = unit_cost;
      BreadChoice = unit_type;
      orders_bread.Add(this);
    }

    public static List<Bread> GetAll()
    {
      return orders_bread;
    }

    public static void ClearAll()
    {
      orders_bread.Clear();
    }
  }
}