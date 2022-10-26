namespace tictaktoe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] spelplan = new char[3,3];
            Border();
            Console.ReadKey(true);
        }
        static void Border(int width = 8, int height = 5)
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
        static void PlayerPlacement()
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("");
        }
    }
}