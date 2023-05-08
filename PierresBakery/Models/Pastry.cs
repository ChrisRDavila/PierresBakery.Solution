
namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Rolls { get;}

    private int roll_cost = 0;
    public Pastry(int _amountPastry)
    {
      Rolls = _amountPastry;
    }

    public int RollCost()
    {
      if(Rolls % 4 == 0)
      {
        roll_cost = ((Rolls -(Rolls / 4)) * 2);
      }
      else if (Rolls < 4)
      {
        roll_cost = Rolls * 2;
      }
      else if((Rolls-1) % 4 == 0)
      {
        roll_cost = (2 * (Rolls -1)) + (2 -(2 * ((Rolls - 1 ) / 4)));
        
      }
      else if((Rolls - 2) % 4 == 0)
      {
        roll_cost = Rolls + (2 * ((Rolls + 2)/4));
      }
      else if((Rolls-3) % 4 == 0)
      {
        roll_cost = (2 * (Rolls)) - (2 * ((Rolls - 3 ) / 4));
        
      } return roll_cost;
    } 

  }
} 