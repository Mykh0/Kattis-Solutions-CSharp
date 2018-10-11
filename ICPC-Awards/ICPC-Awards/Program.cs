using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC_Awards
{
  class Program
  {
    static void Main(string[] args)
    {
      var universities = new List<string>();
      var winners = new List<string>();
      int amountOfTeams = Convert.ToInt32(Console.ReadLine());

      for(int i = 0; i < amountOfTeams; i++)
      {
        string fullTeamName = Console.ReadLine();
        var split = fullTeamName.Split();
        string university = split.ElementAt(0);

        if(!universities.Contains(university))
        {
          universities.Add(university);
          winners.Add(fullTeamName);
        }
      }

      for(int i = 0; i < 12; i++)
      {
        Console.WriteLine(winners.ElementAt(i));
      }
      Console.ReadKey();
    }
  }
}
