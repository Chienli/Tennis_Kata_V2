using System.Collections.Generic;

namespace Tennis_Kata
{
    internal class TennisGame
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;

        private Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>
        {
            {1,"Fifteen"},
            {2,"Thirty"},
            {3,"Forty"}
        };

        public string Score()
        {
            if (_firstPlayerScore != 0)
            {
                return $"{_scoreLookUp[_firstPlayerScore]}_Love";
            }
            if (_secondPlayerScore != 0)
            {
                return $"Love_{_scoreLookUp[_secondPlayerScore]}";
            }
            return "Love_All";
        }

        public void FirstPlayerGetPoint()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerGetPoint()
        {
            _secondPlayerScore++;
        }
    }
}