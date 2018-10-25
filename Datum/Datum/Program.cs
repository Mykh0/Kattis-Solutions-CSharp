using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datum
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = Console.ReadLine().Split(' ');
      int day = Convert.ToInt32(input.ElementAt(0));
      int month = Convert.ToInt32(input.ElementAt(1));

      for(int i = 1; i <= month; i++)
      {
        switch(i)
        {
          case 1:
          default:
            break;
          case 2:
          case 4:
          case 6:
          case 8:
          case 9:
          case 11:
            day += 31;
            break;
          case 3:
            day += 28;
            break;
          case 5:
          case 7:
          case 10:
          case 12:
            day += 30;
            break;
}
      }

      switch(day % 7)
      {
        case 0:
          Console.WriteLine("Wednesday");
          break;
        case 1:
          Console.WriteLine("Thursday");
          break;
        case 2:
          Console.WriteLine("Friday");
          break;
        case 3:
          Console.WriteLine("Saturday");
          break;
        case 4:
          Console.WriteLine("Sunday");
          break;
        case 5:
          Console.WriteLine("Monday");
          break;
        case 6:
          Console.WriteLine("Tuesday");
          break;
        default:
          break;
      }
      Console.ReadKey();
    }
  }
}
