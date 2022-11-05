using System;
using AlgorythmsLab3.Structures.LinkedList;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Interface.functions.list
{
    public class ReverseList : ListMenuItem
    {
        public ReverseList(LinkedList<int> list, bool isSelected = false) : base(list, 
            title: "Перевернуть лист", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            Console.WriteLine($"[{Title.ToUpper()}]\n");

            Console.WriteLine("Изначальный список:");
            Console.WriteLine(List);

            var list = List.Reverse();
            Console.WriteLine("Результат переворота:");
            Console.WriteLine(list);

            ConsoleUtil.Pause();
        }
    }
}