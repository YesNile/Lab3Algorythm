using System;
using AlgorythmsLab3.Structures.LinkedList;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Interface.functions.list
{
    public class SwapFirstAndLast : ListMenuItem
    {
        public SwapFirstAndLast(LinkedList<int> list, bool isSelected = false) : base(list,
            "Поменять местами первый и последний элемент", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            Console.WriteLine($"[{Title.ToUpper()}]\n");

            Console.WriteLine("Изначальный список:");
            Console.WriteLine(List);

            List.SwapFirstAndLast();
            Console.WriteLine("Результат смены первого и последнего элемента:");
            Console.WriteLine(List);

            ConsoleUtil.Pause();
        }
    }
}