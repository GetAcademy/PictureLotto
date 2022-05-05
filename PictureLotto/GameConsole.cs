using System.Text;

namespace PictureLotto
{
    internal class GameConsole
    {
        public static void WriteOpenBox(int row, int col, int index, char character)
        {
            var numberWidth = index < 10 ? 1 : 2;
            Write(row, col - numberWidth, $"{index}╔═══╗");
            Write(row + 1, col, $"║ {character} ║");
            Write(row + 2, col, $"╚═══╝");
        }
        public static void WriteClosedBox(int row, int col, int index)
        {
            var numberWidth = index < 10 ? 1 : 2;
            Write(row, col-numberWidth, $"{index}╔╦╦╦╗");
            Write(row + 1, col, $"╠╬╬╬╣");
            Write(row + 2, col, $"╚╩╩╩╝");
        }

        private static void Write(int row, int col, string txt)
        {
            Console.CursorLeft = col;
            Console.CursorTop = row;
            Console.Write(txt);
        }

        public static int AskForInt(string question)
        {
            Console.Write(question);
            var answer = Console.ReadLine();
            return Convert.ToInt32(answer);
        }
    }
}
