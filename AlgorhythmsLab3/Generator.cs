using System.Text;

namespace AlgorithmsLab3
{
    public class Generator
    {
        public static string GenerateFile(int amountOfCommands)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < amountOfCommands; i++)
            {
                int a = random.Next(1,6);
                sb.Append(a);
                if (a == 1)
                {
                    int value = random.Next();
                    sb.Append(',').Append(value);
                }

                if (i!=amountOfCommands-1)
                {
                    sb.Append(' ');
                }
            }

            return sb.ToString();

        }
    }
}