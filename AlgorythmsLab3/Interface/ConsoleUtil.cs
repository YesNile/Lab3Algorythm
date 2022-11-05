using System;

namespace AlgorythmsLab3.Menu
{
    public class ConsoleUtil
    {
        public static void ClearScreen()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new String(' ', Console.WindowWidth));
            }

            Console.SetCursorPosition(0, 0);
        }

    }
}