using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven_Wonders
{
  class Program
  {
    public class Card
    {
      public int Points { get; private set; }
      public char Play { get; private set; }

      public Card(int points, char play)
      {
        Points = points;
        Play = play;
      }
    }

    static void Main(string[] args)
    {
      var trigger = new Card(3, 'T');
      var compass = new Card(2, 'C');
      var gear = new Card(1, 'G');
      int points = 0;
      string cardsPlayed = Console.ReadLine();
      int triggerCards = cardsPlayed.Count(c => c == trigger.Play);
      int compassCards = cardsPlayed.Count(c => c == compass.Play);
      int gearCards = cardsPlayed.Count(c => c == gear.Play);
      int fullSets = new List<int>() { triggerCards, compassCards, gearCards }.Min();

      points += triggerCards * triggerCards + compassCards * compassCards + gearCards * gearCards + fullSets * 7;
      Console.WriteLine(points);
      Console.ReadLine();
    }
  }
}
 
