using RPSGameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class FirstToTen : GamesBase, IGames
    {
        private int numberOfmoves;

        public FirstToTen()
            : this(new Logic()) { }

        public FirstToTen(ILogic gameLogic)
            : base(gameLogic)
        {
            numberOfmoves = gameLogic.GetNumberOfMoves();
            Description();
        }

        protected override void Description()
        {
            Console.WriteLine("Welcome Player One");
            Console.WriteLine("To play Please enter in a number corresponding to the move");
            Console.WriteLine(gameLogic.Instructions());
            Console.WriteLine("First to ten \n");
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
            for (; ; )
            {
                var choice = -1;
                Console.WriteLine("Make a move.");
                while ((choice = GetInput()) < 0) { Console.WriteLine("Invalid input, please try again."); }

                if (choice < numberOfmoves)
                {
                    var result = MakeAPlay(choice);
                    CalculateScore(result);
                    Console.WriteLine("{0} aginst {1} \n", result, PlayerTwo.Choice);
                    Console.WriteLine("YOU\tComputer");
                    Console.WriteLine("{0}\t{1}", PlayerOne.Score, PlayerTwo.Score);
                }

                if (PlayerOne.Score == 10 || PlayerTwo.Score == 10)
                {
                    break;
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
