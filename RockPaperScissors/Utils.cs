using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Utils
    {
        public static int CheckValidMove(string input, int numMoves)
        {
            var choice = CheckInput(input);
            return (choice < numMoves) ? choice : -1;
        }

        public static int CheckInput(string input)
        {
            int choice = -1;
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Input is not a number!");
                choice = -1;
            }
            return choice;
        }
    }
}
