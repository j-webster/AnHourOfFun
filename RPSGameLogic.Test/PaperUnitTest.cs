using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPSGameLogic.Test
{
    [TestClass]
    public class PaperUnitTest
    {
        [TestMethod]
        public void PaperVsRockNotEqualLose()
        {
            var user = new Paper();
            var computer = new Rock();

            var result = user.Challenge(computer);

            Assert.AreNotEqual(GameResult.Lose, result);
        }

        [TestMethod]
        public void PaperVsRockWin()
        {
            var user = new Paper();
            var computer = new Rock();

            var result = user.Challenge(computer);

            Assert.AreEqual(GameResult.Win, result);
        }

        [TestMethod]
        public void PaperVsRockNotEqualTie()
        {
            var user = new Paper();
            var computer = new Rock();

            var result = user.Challenge(computer);

            Assert.AreNotEqual(GameResult.Tie, result);
        }

        [TestMethod]
        public void PaperVsPaperTie()
        {
            var user = new Paper();
            var computer = new Paper();

            var result = user.Challenge(computer);

            Assert.AreEqual(GameResult.Tie, result);
        }

        [TestMethod]
        public void PaperVsScissorsLose()
        {
            var user = new Paper();
            var computer = new Scissors();

            var result = user.Challenge(computer);

            Assert.AreEqual(GameResult.Lose, result);
        }

        [TestMethod]
        public void PaperVsScissorsNotEqualWin()
        {
            var user = new Paper();
            var computer = new Scissors();

            var result = user.Challenge(computer);

            Assert.AreNotEqual(GameResult.Win, result);
        }

        [TestMethod]
        public void PaperVsScissorsNotEqaulTie()
        {
            var user = new Paper();
            var computer = new Scissors();

            var result = user.Challenge(computer);

            Assert.AreNotEqual(GameResult.Tie, result);
        }
    }
}
