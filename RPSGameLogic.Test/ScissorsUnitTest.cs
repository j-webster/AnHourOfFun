using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPSGameLogic.Test
{
    /// <summary>
    /// Summary description for ScissorsUnitTest
    /// </summary>
    [TestClass]
    public class ScissorsUnitTest
    {
        [TestMethod]
        public void ScissorsVsRockLose()
        {
            var user = new Scissors();
            var computer = new Rock();

            var result = user.Challenge(computer);

            Assert.AreEqual(GameResult.Lose, result);
        }

        [TestMethod]
        public void ScissorsVsRockNotEqualWin()
        {
            var user = new Scissors();
            var computer = new Rock();

            var result = user.Challenge(computer);

            Assert.AreNotEqual(GameResult.Win, result);
        }

        [TestMethod]
        public void ScissorsVsRockNotEqualTie()
        {
            var user = new Scissors();
            var computer = new Rock();

            var result = user.Challenge(computer);

            Assert.AreNotEqual(GameResult.Tie, result);
        }

        [TestMethod]
        public void ScissorsVsScissorsTie()
        {
            var user = new Scissors();
            var computer = new Scissors();

            var result = user.Challenge(computer);

            Assert.AreEqual(GameResult.Tie, result);
        }

        [TestMethod]
        public void ScissorsVsPaperNotEqualLose()
        {
            var user = new Scissors();
            var computer = new Paper();

            var result = user.Challenge(computer);

            Assert.AreNotEqual(GameResult.Lose, result);
        }

        [TestMethod]
        public void ScissorsVsScissorsWin()
        {
            var user = new Scissors();
            var computer = new Paper();

            var result = user.Challenge(computer);

            Assert.AreEqual(GameResult.Win, result);
        }

        [TestMethod]
        public void ScissorsVsScissorsNotEqaulTie()
        {
            var user = new Scissors();
            var computer = new Paper();

            var result = user.Challenge(computer);

            Assert.AreNotEqual(GameResult.Tie, result);
        }
    }
}
