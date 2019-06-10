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
        public void Fifteen_All()
        {
            FirstPlayerGetPointTimes(1);
            SecondPlayerGetPointTimes(1);

            ScoreShouldBe("Fifteen_All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            FirstPlayerGetPointTimes(2);
            SecondPlayerGetPointTimes(2);

            ScoreShouldBe("Thirty_All");
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
            SecondPlayerGetPointTimes(1);

            ScoreShouldBe("Love_Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            SecondPlayerGetPointTimes(2);

            ScoreShouldBe("Love_Thirty");
        }

        [TestMethod]
        public void Love_Forty()
        {
            SecondPlayerGetPointTimes(3);

            ScoreShouldBe("Love_Forty");
        }

        private void SecondPlayerGetPointTimes(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennisGame.SecondPlayerGetPoint();
            }
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