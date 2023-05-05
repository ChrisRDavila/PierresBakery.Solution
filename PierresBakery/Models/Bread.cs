

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadPrice{ get; set; }

    public Bread(int unit_cost)
    {
      BreadPrice = unit_cost;
    }
  }
}