using System;
using AlgorythmsLab3.Structures.LinkedList;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Interface.functions.list
{
    public class RemoveEverSecondElement : MenuItemList
    {
        public RemoveEverSecondElement(LinkedList<int> list, bool isSelected = false) : base(list,
            title: "Удаление всех вторых вхождений элемента", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            Console.WriteLine($"[{Title.ToUpper()}]\n");

            Console.WriteLine("Изначальный список:");
            Console.WriteLine(List);

            List.RemovingSecondElement();
            Console.WriteLine("Результат удаления всех вторых вхождений элемента:");
            Console.WriteLine(List);

            ConsoleUtil.Pause();
        }
    }
}