using RPSGameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class BestOfThreeGame : GamesBase, IGames
    {
        private const int numGame = 3;
        private int numberOfmoves;

        public BestOfThreeGame()
            : this(new Logic()) { }

        public BestOfThreeGame(ILogic gameLogic)
            : base(gameLogic)
        {
            numberOfmoves = gameLogic.GetNumberOfMoves();
            Description();
        }

        protected override void Description()
        {
            Console.WriteLine("Welcome Player One");
            Console.WriteLine("To play please enter a number corresponding to a move");
            Console.WriteLine(gameLogic.Instructions());
            Console.WriteLine("Best of three \n");
        }

        private GameResult MakeAPlay(int choice)
        {
            PlayerOne.Choice = gameLogic.GetChoice(choice);
            Console.WriteLine("Player One chose {0}", PlayerOne.Choice);
            PlayerTwo.Choice = GetComputerChoice();
            return PlayerOne.Choice.Challenge(PlayerTwo.Choice);
        }        

        public void GameStart()
        {
            for (int i = 0; i < numGame; i++)
            {
                var choice = -1;
                Console.WriteLine("Make a move.");
                while ((choice = GetInput()) < 0) { Console.WriteLine("Invalid input, please try again."); }
                
                if (choice < numberOfmoves)
                {
                    var result = MakeAPlay(choice);
                    CalculateScore(result);
                    Console.WriteLine("{0} aginst {1}", result, PlayerTwo.Choice);
                }              

            }

            GameResults();
        }

        private int GetInput()
        {
            return Utils.CheckValidMove(Console.ReadLine(), numberOfmoves);
        }
    }
}
