using System;
using System.Linq;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Interface.functions.stack
{
    public class ConvertToRpn : MenuItem
    {
        public ConvertToRpn(bool isSelected = false) : base("Перевод в постфиксную запись", isSelected)
        {
        }

        public override void Execute()
        {
            Console.CursorVisible = true;
            do
            {
                ConsoleUtil.ClearScreen();
                Console.WriteLine($"[{Title.ToUpper()}]");
                Console.WriteLine("Введите выражение для перевода в постфиксную запись");
                string input = Console.ReadLine();
                string resultLine = StackRPN.ParseInRPN(input);
                if (resultLine == String.Empty)
                {
                    Console.Write("Возникла ошибка при переводе выражения, возможно присутствуют недопустимые символы\n" +
                                  "Строка должна содержать только числа и математические операции (например \"+\", \"/\", \"cos\")\n" +
                                  "Выражение должно быть вида: (2+2) * 2\n");
                }
                else
                {
                    var rpnLine = resultLine.Replace(" ", "").ToCharArray().Select(x => x.ToString()).ToList();
                    double result = StackRPN.CalculateRPN(rpnLine);
                    Console.WriteLine($"Результат перевода: ( {resultLine} ) = {result}");
                }
            } while (ConsoleUtil.Continue());

            Console.CursorVisible = false;
        }
    }
}