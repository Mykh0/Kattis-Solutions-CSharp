using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Rot
{
  class Program
  {
    static void Main(string[] args)
    {
      var code = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_.";

      var userInput = new string(Console.ReadLine().ToUpper().ToArray());
      var userInputSplit = userInput.Split();
      var rotateCount = Convert.ToInt32(userInputSplit.ElementAt(0));

      do
      {
        if(rotateCount != 0)
        {
          var message = userInputSplit.ElementAt(1).Reverse();
          var encryptedMessage = "";

          for(int i = 0; i < message.Count(); i++)
          {
            var character = message.ElementAt(i);
            var codeIndex = code.IndexOf(character);

            var encryptedIndex = codeIndex + rotateCount;
              
            while(encryptedIndex > code.Count() - 1)
            {
              encryptedIndex -= code.Count();
            }

            var encryptedCharacter = code.ElementAt(encryptedIndex);
            encryptedMessage += encryptedCharacter;
          }

          Console.WriteLine(encryptedMessage);
          userInput = new string(Console.ReadLine().ToArray());
          userInputSplit = userInput.Split();

          if(userInputSplit.Count() != 1)
          {
            rotateCount = Convert.ToInt32(userInputSplit.ElementAt(0));
          }
          else
          {
            rotateCount = 0;
          }
        }
      } while(rotateCount != 0);
    }
  }
}