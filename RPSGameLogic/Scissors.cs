using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGameLogic
{
    public class Scissors : GameStrategy
    {
        public GameResult Challenge(GameStrategy opponentChoice)
        {
            return opponentChoice.GetResult(this);
        }

        public GameResult GetResult(Rock choice)
        {
            return GameResult.Win;
        }

        public GameResult GetResult(Paper choice)
        {
            return GameResult.Lose;
        }

        public GameResult GetResult(Scissors choice)
        {
            return GameResult.Tie;
        }

        public override string ToString()
        {
            return "Scissors";
        }
    }
}
