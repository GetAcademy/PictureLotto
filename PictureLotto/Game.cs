namespace PictureLotto
{
    internal class Game
    {
        private readonly Card[] _cards;
        private Card? _selectedCard;
        public bool IsRunning => _cards.Any(c => !c.IsOpen);

        public Game()
        {
            const string baseSymbols = "ABCDEFGHIJ";
            _cards = (baseSymbols + baseSymbols)
                .ToCharArray()
                .OrderBy(x => Guid.NewGuid())
                .Select((c,i) => new Card(c, i))
                .ToArray();
            _selectedCard = null;
        }

        public void Show()
        {
            Console.Clear();
            foreach (var card in _cards)
            {
                card.Show();
            }

            Console.WriteLine();
        }

        public void SelectCard(int cardIndex)
        {
            var card = _cards[cardIndex];
            card.IsOpen = true;
            Show();
            if (_selectedCard != null && !card.IsMatch(_selectedCard))
            {
                card.IsOpen = false;
                _selectedCard.IsOpen = false;
                Thread.Sleep(2000);
                Show();
            }
            _selectedCard = _selectedCard==null ? card : null;
        }
    }
}
