namespace Kings_Card_Game
{
    public abstract class Card
    {
        private string _cardName;
        private string _cardRule;
        private string _cardImagePath;

        public void SetCardName(string name)
        {
            _cardName = name;
        }

        public void SetCardRule(string rule)
        {
            _cardRule = rule;
        }

        public void SetImagePath(string path)
        {
            _cardImagePath = path;
        }

        public string GetCardName()
        {
            return _cardName;
        }

        public string GetCardRule()
        {
            return _cardRule;
        }

        public string GetImagePath()
        {
            return _cardImagePath;
        }
    }
}
