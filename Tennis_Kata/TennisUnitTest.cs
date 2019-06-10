using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tennis_Kata
{
    [TestClass]
    public class TennisUnitTest
    {
        private readonly TennisGame _tennisGame = new TennisGame();

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love_All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            _tennisGame.FirstPlayerGetPoint();
            ScoreShouldBe("Fifteen_Love");
        }

        private void ScoreShouldBe(string expected)
        {
            var score = _tennisGame.Score();
            Assert.AreEqual(expected , score);
        }
    }
}
