

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadPrice{ get; set; }
    public string BreadChoice{ get; set; }

    public Bread(int unit_cost, string unit_type)
    {
      BreadPrice = unit_cost;
      BreadChoice = unit_type;
    }
  }
}