using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGameLogic
{
    public interface GameStrategy
    {
        GameResult Challenge(GameStrategy opponentChoice);
        GameResult GetResult(Rock choice);
        GameResult GetResult(Paper choice);
        GameResult GetResult(Scissors choice);
    }
}
