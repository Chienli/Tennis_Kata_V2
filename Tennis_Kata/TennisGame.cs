namespace Tennis_Kata
{
    internal class TennisGame
    {
        private int _FirstPlayerScore;

        public string Score()
        {
            if (_FirstPlayerScore==1)
            {
                return "Fifteen_Love";
            }
            if (_FirstPlayerScore == 2)
            {
                return "Thirty_Love";
            }
            return "Love_All";
        }

        public void FirstPlayerGetPoint()
        {
            _FirstPlayerScore++;
        }
    }
}