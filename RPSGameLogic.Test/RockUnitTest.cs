using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPSGameLogic.Test
{
    [TestClass]
    public class RockUnitTest
    {
        [TestMethod]
        public void RockVsPaperLose()
        {
            var user = new Rock();
            var computer = new Paper();

            var result = user.Challenge(computer);

            Assert.AreEqual(GameResult.Lose, result);
        }

        [TestMethod]
        public void RockVsPaperNotEqualWin()
        {
            var user = new Rock();
            var computer = new Paper();

            var result = user.Challenge(computer);

            Assert.AreNotEqual(GameResult.Win, result);
        }

        [TestMethod]
        public void RockVsPaperNotEqualTie()
        {
            var user = new Rock();
            var computer = new Paper();

            var result = user.Challenge(computer);

            Assert.AreNotEqual(GameResult.Tie, result);
        }

        [TestMethod]
        public void RockVsRockTie()
        {
            var user = new Rock();
            var computer = new Rock();

            var result = user.Challenge(computer);

            Assert.AreEqual(GameResult.Tie, result);
        }

        [TestMethod]
        public void RockVsScissorsNotEqualLose()
        {
            var user = new Rock();
            var computer = new Scissors();

            var result = user.Challenge(computer);

            Assert.AreNotEqual(GameResult.Lose, result);
        }

        [TestMethod]
        public void RockVsScissorsWin()
        {
            var user = new Rock();
            var computer = new Scissors();

            var result = user.Challenge(computer);

            Assert.AreEqual(GameResult.Win, result);
        }

        [TestMethod]
        public void RockVsScissorsNotEqualTie()
        {
            var user = new Rock();
            var computer = new Scissors();

            var result = user.Challenge(computer);

            Assert.AreNotEqual(GameResult.Tie, result);
        }
    }
}
