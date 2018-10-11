using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apaxiaaaaaaaaaaaans_
{
  class Program
  {
    static void Main(string[] args)
    {
      string apaxianName = Console.ReadLine();
      var doubleChars = new List<int>();

      for(int i = 1; i < apaxianName.Length; i++)
      {
        if(apaxianName.ElementAt(i) == apaxianName.ElementAt(i-1))
        {
          doubleChars.Add(i);
        }
      }

      doubleChars.Reverse();

      for(int i = 0; i < doubleChars.Count(); i++)
      {
        apaxianName = apaxianName.Remove(doubleChars.ElementAt(i), 1);
      }

      Console.WriteLine(apaxianName);
      Console.ReadKey();
    }
  }
}
