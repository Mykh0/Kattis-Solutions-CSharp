using System;
using System.Linq;

namespace No_Duplicates
{
  class Program
  {
    static void Main(string[] args)
    {
      string input = Console.ReadLine();
      var arrayInput = input.Split(' ').ToList();

      if(arrayInput.GroupBy(r => r).Where(g => g.Count() > 1).Any())
      {
        Console.WriteLine("no");
      }
      else
      {
        Console.WriteLine("yes");
      }
      Console.ReadLine();
    }
  }
}
