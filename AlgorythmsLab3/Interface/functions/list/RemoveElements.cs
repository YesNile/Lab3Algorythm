using System;
using AlgorythmsLab3.Structures.LinkedList;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Interface.functions.list
{
    public class RemoveElements : ListMenuItem
    {
        public RemoveElements(LinkedList<int> list, bool isSelected = false) : base(list,
            title: "Удаление всех вхождений элемента", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            Console.WriteLine($"[{Title.ToUpper()}]\n");
            
            Console.WriteLine("Изначальный список:");
            Console.WriteLine(List);

            Console.WriteLine("Введите целое число: ");
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

                List.RemoveElements(value);
                Console.WriteLine("Результат удаления всех вхождений элемента:");
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