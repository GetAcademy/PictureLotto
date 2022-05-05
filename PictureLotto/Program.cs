using PictureLotto;

const int boxesPerRow = 4;
const int gapCol = 10;
const int gapRow = 4;
for (var i = 0; i < 20; i++)
{
    var rowIndex = i / boxesPerRow;
    var colIndex = i % boxesPerRow;
    var consoleRow = rowIndex * gapRow + 1;
    var consoleCol = colIndex * gapCol + 2;
    if (i % 2 == 0)
    {
        GameConsole.WriteClosedBox(consoleRow, consoleCol, i);
    }
    else
    {
        var c = (char)('A' + i);
        GameConsole.WriteOpenBox(consoleRow, consoleCol,i, c);
    }
}

