using System.Net.Http.Headers;

namespace tictaktoe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] spelplan = { '-', '-', '-', '-', '-', '-', '-', '-', '-' };
            Border();
            int mark;
            while (true) {
                do
                {
                    mark = GetPlayerPlacement("Spelare 1");
                } while (!(spelplan[mark - 1] == '-'));
                spelplan[mark - 1] = 'x';
                Printmarker(mark,'x');
                do
                {
                    mark = GetPlayerPlacement("Spelare 2");
                } while (!(spelplan[mark - 1] == '-'));
                spelplan[mark - 1] = 'o';
                Printmarker(mark, 'o');
                //spelplan[GetPlayerPlacement("Spelare 2")] = 'y';
            }
        }
        static void Border(int width = 2, int height = 2)
        {
            for(int i = 0; i < height * 3 + 1; i++)
            {
                for(int j = 0; j < width * 3 + 1; j++)
                {
                    switch (i % height == 0 , j % width == 0)
                    {
                        case (true, true):
                            Console.SetCursorPosition(j, i);
                            Console.Write("╬");
                            break;
                        case (true, false):
                            Console.SetCursorPosition(j, i);
                            Console.Write("═");
                            break;
                        case (false, true):
                            Console.SetCursorPosition(j, i);
                            Console.Write("║");
                            break;
                    }
                }
            }
        }
        static void Printmarker(int i, char m = 'x')
        {
            switch (i)
            {
                case 1:
                    Console.SetCursorPosition(1, 1);
                    Console.Write(m);
                    break;
                case 2:
                    Console.SetCursorPosition(3, 1);
                    Console.Write(m);
                    break;
                case 3:
                    Console.SetCursorPosition(5, 1);
                    Console.Write(m);
                    break;
                case 4:
                    Console.SetCursorPosition(1, 3);
                    Console.Write(m);
                    break;
                case 5:
                    Console.SetCursorPosition(3, 3);
                    Console.Write(m);
                    break;
                case 6:
                    Console.SetCursorPosition(5, 3);
                    Console.Write(m);
                    break;
                case 7:
                    Console.SetCursorPosition(1, 5);
                    Console.Write(m);
                    break;
                case 8:
                    Console.SetCursorPosition(3, 5);
                    Console.Write(m);
                    break;
                case 9:
                    Console.SetCursorPosition(5, 5);
                    Console.Write(m);
                    break;
            }
        }
        static int GetPlayerPlacement(string txt = "Spelare")
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine(txt + " välj en ruta(1-9): ");
            int ret;
            int.TryParse(Console.ReadKey().KeyChar.ToString(),out ret);
            Console.SetCursorPosition(0, 21);
            Console.WriteLine("   ");
            return ret;
            
        }
        static int Win(char[] rutor, char xo)
        {
            
            return 0;
        }
    }
}