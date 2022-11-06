using System;
using System.Text;

namespace AlgorithmsLab3
{
    public class Generator
    {
        public static string GenerateRandomCommands(int amountOfCommands)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < amountOfCommands; i++)
            {
                int a = random.Next(1, 6);
                sb.Append(a);
                if (a == 1)
                {
                    int value = random.Next(0, 10_000);
                    sb.Append(',').Append(value);
                }

                if (i != amountOfCommands - 1)
                {
                    sb.Append(' ');
                }
            }

            return sb.ToString();
        }

        public static string GenerateRandomCommandsByPattern(int amountOfCommands, params int[] commands)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < amountOfCommands; i++)
            {
                foreach (var command in commands)
                {
                    if (command == 1)
                    {
                        int value = random.Next(0, 10_000);
                        sb.Append($"{command},{value} ");
                    }
                    else
                    {
                        sb.Append($"{command} ");
                    }
                }
            }

            return sb.ToString().Trim();
        }
    }
}