using System;
using AlgorythmsLab3.Structures.LinkedList;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Interface.functions.list
{
    public class CountDistinctElements : ListMenuItem
    {
        public CountDistinctElements(LinkedList<int> list, bool isSelected = false) : base(list,
            title: "Определение количества различных элементов списка", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            Console.WriteLine($"[{Title.ToUpper()}]\n");

            Console.WriteLine("Изначальный список:");
            Console.WriteLine(List);

            var list = List.CountWhole();
            Console.WriteLine("Количество различных элементов списка:");
            Console.WriteLine(list);

            ConsoleUtil.Pause();
        }
    }
}