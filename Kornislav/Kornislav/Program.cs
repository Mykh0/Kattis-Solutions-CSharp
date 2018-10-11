using System;
using System.Collections.Generic;
using System.Linq;

namespace Kornislav
{
  class Program
  {
    static void Main(string[] args)
    {
      string userInput = Console.ReadLine();
      var numbersList = new List<int>();

      numbersList = userInput.Split(' ').ToList().ConvertAll(Convert.ToInt32);
      numbersList.Sort();
      Console.WriteLine(numbersList.ElementAt(0) * numbersList.ElementAt(2));
    }
  }
}
