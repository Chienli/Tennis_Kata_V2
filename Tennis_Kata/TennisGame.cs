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

            return "Love_All";
        }

        public void FirstPlayerGetPoint()
        {
            _FirstPlayerScore++;
        }
    }
}