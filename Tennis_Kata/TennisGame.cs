namespace Tennis_Kata
{
    internal class TennisGame
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;

        public string Score()
        {
            if (_firstPlayerScore == 1)
            {
                return "Fifteen_Love";
            }
            if (_firstPlayerScore == 2)
            {
                return "Thirty_Love";
            }
            if (_firstPlayerScore == 3)
            {
                return "Forty_Love";
            }
            if (_secondPlayerScore == 1)
            {
                return "Love_Fifteen";
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