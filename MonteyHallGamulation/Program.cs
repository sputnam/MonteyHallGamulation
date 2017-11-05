using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteyHallGamulation
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Choice = keep door");
      int wins = 0;
      Random rand = new Random(DateTime.Now.Millisecond);
      int runs = 1000;

      for (int i = 0; i < runs; i++)
      {
        int winner = rand.Next(0, 3);
        int guess = rand.Next(0, 3);
        if (winner == guess)
        {
          wins++;
          Console.WriteLine("I'm a winner!");
        }
        else
        {
          Console.WriteLine("I've had better days :-(");
        }     
      }
      Console.WriteLine((wins / (runs * 1.0) * 100).ToString());
      

      Console.WriteLine("Choice = change door");
      wins = 0;

      for (int i = 0; i < runs; i++)
      {
        int winner = rand.Next(0, 3);
        int guess = rand.Next(0, 3);
        if (winner != guess)
        {
          wins++;
          Console.WriteLine("I've had better days :-(");
        }
        else
        {          
          Console.WriteLine("I'm a winner!");
        }
      }
      Console.WriteLine((wins / (runs * 1.0) * 100).ToString());
      int bleh = 0;
    }
  }
}
