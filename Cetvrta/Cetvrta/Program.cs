using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cetvrta
{
  class Program
  {
    static void Main(string[] args)
    {
      var X = new List<int>();
      var Y = new List<int>();

      for(int i = 0; i < 3; i++)
      {
        var input = Console.ReadLine().Split(' ').ToList();
        int x = Convert.ToInt32(input.ElementAt(0));
        int y =  Convert.ToInt32(input.ElementAt(1));

        if(X.Contains(x))
        {
          X.Remove(X.SingleOrDefault(z => z == x));
        }
        else
        {
          X.Add(x);
        }

        if(Y.Contains(y))
        {
          Y.Remove(Y.SingleOrDefault(z => z == y));
        }
        else
        {
          Y.Add(y);
        }
      }

      string output = $"{X.FirstOrDefault()} {Y.FirstOrDefault()}";

      Console.WriteLine(output);
    }
  }
}
