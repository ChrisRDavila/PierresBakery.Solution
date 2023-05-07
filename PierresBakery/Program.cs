using System;
using PierresBakery.Models;
using PierresBakery.UserInterfaceModels;

namespace PierresBakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.Write(WelcomeBanner.Welcome);
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Hello and Welcome to Pierres Bakery app!");
      Console.WriteLine("\nWe Specialize in two items: \nBread 5$ each \nPastry 2$ each");
      Console.WriteLine("\nWere currently running a deal on both \nBuy Two Loaves of Bread, get One Free \nBuy Three Pastries and Get One Free ");
      Console.WriteLine("\nWould You Like to purchase any Bread");
      Console.WriteLine("\nIf yes please enter 'yes', if no please enter 'no'");
      string breadAnswer = Console.ReadLine();
      if(breadAnswer == "yes")
      {
        PastryOrder();
      } else if (breadAnswer == "no")
      {
        JustPastry();
      }
      static void PastryOrder()
      {
        Console.WriteLine("\nWould You Like to purchase any Pastries");
        Console.WriteLine("\nIf yes please enter 'yes', if no please enter 'no'");
        string _pastryAnswer = Console.ReadLine();
        if (_pastryAnswer == "yes")
        {
          OrderInput();
        }
        else if (_pastryAnswer == "no")
        {
          JustBread();
        }  
      }
    static void OrderInput()
      {
      Console.WriteLine("\nHow many loaves of bread would you like to purchase?");
      Console.WriteLine("\nPlease enter a positive whole number for your bread order:");
      int _amountLoaves = int.Parse(Console.ReadLine());
      Console.WriteLine("\nHow many pastries would you like to purchase?");
      Console.WriteLine("\nPlease enter a positive whole number for your pastry order:");
      int _amountPastries = int.Parse(Console.ReadLine());
      Console.Write(Calculating.Sum);
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Bread breadOrder = new Bread(_amountLoaves);
      Pastry pastryOrder = new Pastry(_amountPastries);
      int breadBill = breadOrder.CarbCost();
      int pastryBill = pastryOrder.RollCost();
      int totalBill = breadBill + pastryBill;
      Console.WriteLine($"\nYour order total for Bread is \n${breadBill}.00 dollars\nYour order total for Pastries is \n${pastryBill}.00 dollars");
      Console.WriteLine($"\nYour total for the full order is \n${totalBill}.00 dollars");
      Goodbye();
      }    
    static void JustPastry()
    {
      Console.WriteLine("\nWell, Im guessing you came for our other item? How many pastries would you like to purchase?");
      Console.WriteLine("\nPlease enter a positive whole number for your pastry order:");
      int _amountPastries = int.Parse(Console.ReadLine());
      Console.Write(Calculating.Sum);
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Pastry pastryOrder = new Pastry(_amountPastries);
      int pastryBill = pastryOrder.RollCost();
      Console.WriteLine($"\nYour order total for Pastries is \n${pastryBill}.00 dollars");
      Console.WriteLine("\nEnjoy your meal!!!");
      Goodbye();
    }
    static void JustBread()
    {
      Console.WriteLine("\nHow many loaves of bread would you like to purchase?");
      Console.WriteLine("\nPlease enter a positive whole number for your bread order:");
      int _amountLoaves = int.Parse(Console.ReadLine());
      Console.Write(Calculating.Sum);
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Bread breadOrder = new Bread(_amountLoaves);
      int breadBill = breadOrder.CarbCost();
      Console.WriteLine($"\nYour order total for Bread is \n${breadBill}.00 dollars");
      Goodbye();
    }
    static void Goodbye()
    {
      Console.Write(GoodbyeBanner.Goodbye);
      Console.WriteLine("Thanks for dining with us");
      
    }  
    }
  }
}   