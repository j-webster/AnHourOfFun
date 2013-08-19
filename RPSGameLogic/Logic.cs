using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGameLogic
{
    public class Logic : ILogic
    {        
        public const int NUM_OF_MOVES = 3;

        private Random rand = new Random();

        public string Instructions()
        {
            return string.Format("Rock: 0, Paper: 1, Scissors: 2");
        }

        public int GetNumberOfMoves()
        {
            return NUM_OF_MOVES;
        }

        public GameStrategy ComputerPick()
        {
            return GetChoice(rand.Next(0, 3));
        }

        public GameStrategy GetChoice(int choiceVal)
        {

            switch ((GameMoves)choiceVal)
            {
                case GameMoves.ROCK:
                    return new Rock();
                case GameMoves.PAPER:
                    return new Paper();
                case GameMoves.SCISSORS:
                    return new Scissors();
                default:
                    throw new ArgumentException("Not a valid choice.");
            }
        }
    }
}
