using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class FindGame
    {
        public static IGames GetGame(int gameNumber)
        {
            switch (gameNumber)
            {
                case 0:
                    return new BestOfThreeGame();
                case 1:
                    return new ComputerVsComputer();
                case 2:
                    return new FirstToTen();
                default:
                    throw new ArgumentException("Not a valid game.");
            }
        }
    }
}
