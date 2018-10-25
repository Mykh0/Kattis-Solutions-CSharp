using System;
using System.Collections.Generic;
using System.Linq;

namespace Modulo
{
  class Program
  {
    static void Main(string[] args)
    {
          List<int> modulo42 = new List<int>();

      for(int i = 0; i < 10; i++)
      {
        int input = Convert.ToInt32(Console.ReadLine());

        if(!modulo42.Contains(input % 42))
        {
          modulo42.Add(input % 42);
        }
      }
      Console.WriteLine(modulo42.Count());
    }
  }
}
