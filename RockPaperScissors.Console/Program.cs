using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Description();

            int gameNumber = Utils.CheckInput(Console.ReadLine());
            program.PlayGame(gameNumber);

            Console.ReadLine();
        }

        public void Description()
        {
            Console.WriteLine("Chose a Game");
            Console.WriteLine("Best Of three press 0 or Computer vs Computer press 1 or First to ten press 2 \n");
        }

        public void PlayGame(int gameNumber)
        {
            var game = FindGame.GetGame(gameNumber);
            game.GameStart();
        } 
        
    }
}
