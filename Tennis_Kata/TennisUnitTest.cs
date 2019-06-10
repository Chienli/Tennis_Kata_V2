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
            FirstPlayerGetPointTimes(1);

            ScoreShouldBe("Fifteen_Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            FirstPlayerGetPointTimes(2);

            ScoreShouldBe("Thirty_Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            FirstPlayerGetPointTimes(3);

            ScoreShouldBe("Forty_Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            _tennisGame.SecondPlayerGetPoint();

            ScoreShouldBe("Love_Fifteen");
        }

        private void FirstPlayerGetPointTimes(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennisGame.FirstPlayerGetPoint();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            var score = _tennisGame.Score();
            Assert.AreEqual(expected, score);
        }
    }
}