using System;
using AlgorythmsLab3.Structures.LinkedList;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Interface.functions.list
{
    public class DoublingList : MenuItemList
    {
        public DoublingList(LinkedList<int> list, bool isSelected = false) : base(list, title: "Удвоение списка", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            Console.WriteLine($"[{Title.ToUpper()}]\n");

            Console.WriteLine("Изначальный список:");
            Console.WriteLine(List);

            List.DoublingList();
            Console.WriteLine("Результат удвоения списка:");
            Console.WriteLine(List);

            ConsoleUtil.Pause();
        }
    }
}