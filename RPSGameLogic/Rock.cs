using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGameLogic
{
    public class Rock : GameStrategy
    {
        public GameResult Challenge(GameStrategy opponentChoice)
        {
            return opponentChoice.GetResult(this);
        }

        public GameResult GetResult(Rock choice)
        {
            return GameResult.Tie;
        }

        public GameResult GetResult(Paper choice)
        {
            return GameResult.Win;
        }

        public GameResult GetResult(Scissors choice)
        {
            return GameResult.Lose;
        }

        public override string ToString()
        {
            return "Rock";
        }
    }
}
