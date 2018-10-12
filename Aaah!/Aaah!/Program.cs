using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aaah_
{
  class Program
  {
    static void Main(string[] args)
    {
      string max = Console.ReadLine();
      string doctor = Console.ReadLine();

      int max_a = max.Count(s => s == 'a');
      int doctor_a = doctor.Count(s => s == 'a');

      if(max_a >= doctor_a)
      {
        Console.WriteLine("go");
      }
      else
      {
        Console.WriteLine("no");
      }
    }
  }
}
