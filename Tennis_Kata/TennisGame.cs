using System;
using System.Collections.Generic;

namespace Tennis_Kata
{
    internal class TennisGame
    {
        private readonly string _firstPlayerName;
        private int _firstPlayerScore;
        private int _secondPlayerScore;

        public TennisGame(string firstPlayerName)
        {
            this._firstPlayerName = firstPlayerName;
        }

        private Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>
        {
            {0,"Love" },
            {1,"Fifteen"},
            {2,"Thirty"},
            {3,"Forty"}
        };

        public string Score()
        {
            if (_firstPlayerScore != _secondPlayerScore)
            {
                if (_firstPlayerScore > 3 || _secondPlayerScore > 3)
                {
                    if (Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1)
                    {
                        return "Guy_Adv";
                    }
                }

                return $"{_scoreLookUp[_firstPlayerScore]}_{_scoreLookUp[_secondPlayerScore]}";
            }
            else
            {
                if (_firstPlayerScore >= 3)
                {
                    return "Deuce";
                }
                return $"{_scoreLookUp[_firstPlayerScore]}_All";
            }
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