using System;
using System.Collections.Generic;
using System.Linq;

namespace Bela
{
  class Program
  {
    static void Main(string[] args)
    {
      int points = 0;
      var input = Console.ReadLine().Split(' ');
      string dominantSuit = input.ElementAt(1);
      var dominantCardPoints = new List<int>() { 11, 4, 3, 20, 10, 14, 0, 0 };
      var nonDominantCardPoints = new List<int>() { 11, 4, 3, 2, 10, 0, 0, 0 };
      var cardList = new List<string>() { "A", "K", "Q", "J", "T", "9", "8", "7" };

      for(int i = 0; i < Convert.ToInt32(input.ElementAt(0))*4; i++)
      {
        var card = Console.ReadLine();
        string pointCard = card.ElementAt(0).ToString();
        int pointCardIndex = cardList.IndexOf(pointCard);

        if(card.ElementAt(1).ToString() == dominantSuit)
        {
          points += dominantCardPoints.ElementAt(pointCardIndex);
        }
        else
        {
                    points += nonDominantCardPoints.ElementAt(pointCardIndex);
        }
      }
      Console.WriteLine(points);
      Console.ReadLine();
    }
  }
}
