using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGameLogic
{
    public interface ILogic
    {
        string Instructions();

        int GetNumberOfMoves();

        GameStrategy ComputerPick();

        GameStrategy GetChoice(int choiceVal);
    }
}
