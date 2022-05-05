namespace PictureLotto
{
    internal class Card
    {
        private readonly char _character;
        private readonly int _index;
        const int BoxesPerRow = 4;
        const int GapCol = 10;
        const int GapRow = 4;
        public bool IsOpen { get; set; }

        public Card(char character, int index)
        {
            _index = index;
            _character = character;
            IsOpen = false;
        }

        public bool IsMatch(Card otherCard)
        {
            return _character == otherCard._character;
        }

        public void Show()
        {
            var rowIndex = _index / BoxesPerRow;
            var colIndex = _index % BoxesPerRow;
            var consoleRow = rowIndex * GapRow + 1;
            var consoleCol = colIndex * GapCol + 2;

            if (IsOpen)
                GameConsole.WriteOpenBox(
                    consoleRow, consoleCol, _index, _character);
            else
                GameConsole.WriteClosedBox(
                    consoleRow, consoleCol, _index);

        }
    }
}
