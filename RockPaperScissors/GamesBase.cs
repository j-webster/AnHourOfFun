using RPSGameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public abstract class GamesBase
    {
        protected Player PlayerOne { get; set; }
        protected Player PlayerTwo { get; set; }

        protected ILogic gameLogic;

        public GamesBase(ILogic gameLogic)
        {
            this.gameLogic = gameLogic;
            PlayerOne = new Player();
            PlayerTwo = new Player();
        }

        protected GameStrategy GetComputerChoice()
        {
            return gameLogic.ComputerPick();
        }

        protected void CalculateScore(GameResult result)
        {
            switch (result)
            {
                case GameResult.Lose:
                    PlayerTwo.Score++;
                    break;
                case GameResult.Win:
                    PlayerOne.Score++;
                    break;
            }
        }

        protected void GameResults()
        {
            if (PlayerOne.Score == PlayerTwo.Score)
            {
                Console.WriteLine("Player One tied against Player Two.");
            }
            else if (PlayerOne.Score > PlayerTwo.Score)
            {
                Console.WriteLine("Player One won the game.");
            }
            else
            {
                Console.WriteLine("Player One lost the game against Player Two.");
            }

            Console.WriteLine("Player One \t PlayerTwo");
            Console.WriteLine("{0}        \t {1}", PlayerOne.Score, PlayerTwo.Score);
        }

        protected abstract void Description();
    }
}
