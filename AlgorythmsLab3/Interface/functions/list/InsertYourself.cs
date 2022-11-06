using System;
using AlgorythmsLab3.Structures.LinkedList;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Interface.functions.list
{
    public class InsertYourself : MenuItemList
    {
        public InsertYourself(LinkedList<int> list, bool isSelected = false) : base(list,
            title: "Вставка списка самого в себя", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            Console.WriteLine($"[{Title.ToUpper()}]\n");
            
            Console.WriteLine("Изначальный список:");
            Console.WriteLine(List);

            Console.WriteLine("Введите число, после которого будет вставлен список: ");
            Console.CursorVisible = true;

            string input = Console.ReadLine();
            int value;
            try
            {
                value = int.Parse(input);
            }
            catch (Exception e)
            {
                value = -1;
            }

            if (value != -1)
            {
                Console.CursorVisible = false;

                List.PasteYourself(value);
                Console.WriteLine("Результат вставки списка самого в себя:");
                Console.WriteLine(List);
            }
            else
            {
                Console.WriteLine("Введенное значение не является целым числом");
            }

            ConsoleUtil.Pause();
        }
    }
}