using System;
using System.Collections.Generic;

namespace Tennis_Kata
{
    internal class TennisGame
    {
        private readonly string _firstPlayerName;
        private readonly string _secondPlayerName;
        private int _firstPlayerScore;
        private int _secondPlayerScore;

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            this._firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        private readonly Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>
        {
            {0,"Love" },
            {1,"Fifteen"},
            {2,"Thirty"},
            {3,"Forty"}
        };

        public string Score()
        {
            return IsDiff() ? IsGamePoint()
                    ? IsAdvance() ? $"{GetAdvanceName()}_Adv" : $"{GetAdvanceName()}_Win"
                    : $"{_scoreLookUp[_firstPlayerScore]}_{_scoreLookUp[_secondPlayerScore]}" :
                IsDeuce() ? "Deuce" : $"{_scoreLookUp[_firstPlayerScore]}_All";
        }

        private bool IsDeuce()
        {
            return _firstPlayerScore >= 3;
        }

        private bool IsAdvance()
        {
            return Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1;
        }

        private bool IsGamePoint()
        {
            return _firstPlayerScore > 3 || _secondPlayerScore > 3;
        }

        private bool IsDiff()
        {
            return _firstPlayerScore != _secondPlayerScore;
        }

        private string GetAdvanceName()
        {
            return _firstPlayerScore > _secondPlayerScore ? _firstPlayerName : _secondPlayerName;
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