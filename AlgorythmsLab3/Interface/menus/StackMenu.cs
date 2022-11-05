using System;
using AlgorythmsLab3.Menu;

namespace AlgorhythmsLab3.Interface.menus
{
    public class StackMenu : MenuItem
    {
        public StackMenu(bool isSelected = false) : base("Тестирование стэка", isSelected) { }

        public override void Execute()
        {
            Console.WriteLine("Ты думал здесь что-то будет?");
            Console.ReadLine();
        }
    }
}