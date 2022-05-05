using PictureLotto;

var game = new Game();
while (game.IsRunning)
{
    game.Show();
    var cardIndex = GameConsole.AskForInt("Hvilket kort velger du? ");
    game.SelectCard(cardIndex);
}
game.Show();
Console.WriteLine("Gratulerer, du har fullført spillet!");


/*

const string baseSymbols = "ABCDEFGHIJ";
var symbols = new string((baseSymbols + baseSymbols)
    .ToCharArray()
    .OrderBy(x => Guid.NewGuid())
    .ToArray()
);

const int boxesPerRow = 4;
const int gapCol = 10;
const int gapRow = 4;
for (var i = 0; i < 20; i++)
{
    var rowIndex = i / boxesPerRow;
    var colIndex = i % boxesPerRow;
    var consoleRow = rowIndex * gapRow + 1;
    var consoleCol = colIndex * gapCol + 2;
    var c = symbols[i];
    if (i % 2 == 0) GameConsole.WriteClosedBox(consoleRow, consoleCol, i);
    else GameConsole.WriteOpenBox(consoleRow, consoleCol, i, c);
}

*/