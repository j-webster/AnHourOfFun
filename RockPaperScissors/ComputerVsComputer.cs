using RPSGameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class ComputerVsComputer : GamesBase, IGames
    {
        private const int numGame = 3;

        public ComputerVsComputer()
            : this(new Logic()) { }

        public ComputerVsComputer(ILogic gameLogic)
            :base(gameLogic)
        {
            Description();
        }

        protected override void Description()
        {
            Console.WriteLine("Computer vs Computer");
            Console.WriteLine("Best of three \n");
        }


        private GameResult MakeAPlay()
        {
            return PlayerOne.Choice.Challenge(PlayerTwo.Choice);
        }

        public void GameStart()
        {
            for (int i = 0; i < numGame; i++)
            {
                PlayerOne.Choice = GetComputerChoice();
                PlayerTwo.Choice = GetComputerChoice();
                var result = MakeAPlay();
                CalculateScore(result);
                Console.WriteLine("Player One: {0} {1} aginst Player Two: {2}", PlayerOne.Choice, result, PlayerTwo.Choice);
            }

            GameResults();
        }

    }
}
