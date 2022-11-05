using System;
using System.Linq;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Interface.functions.stack
{
    public class ConvertFromRpn : MenuItem
    {
        public ConvertFromRpn(bool isSelected = false) : base("Вычисление выражения, записанного в постфиксной записи",
            isSelected)
        {
        }

        public override void Execute()
        {
            Console.CursorVisible = true;
            do
            {
                ConsoleUtil.ClearScreen();
                Console.WriteLine($"[{Title.ToUpper()}]\n");
                Console.WriteLine("Введите выражение для подсчета");
                string input = Console.ReadLine();
                try
                {
                    var rpnLine = input.Replace(" ", "").ToCharArray().Select(x => x.ToString()).ToList();
                    double result = StackRPN.CalculateRPN(rpnLine);
                    Console.WriteLine($"Результат перевода: ( {input} ) = {result}");
                }
                catch (Exception e)
                {
                    Console.Write(
                        "Возникла ошибка при переводе выражения, возможно присутствуют недопустимые символы\n" +
                        "Строка должна содержать только числа и математические операции (например \"+\", \"/\", \"cos\")\n" +
                        "Выражение должно быть вида: 7 8 + 3 2 + /\n");
                }
            } while (ConsoleUtil.Continue());
        }
    }
}