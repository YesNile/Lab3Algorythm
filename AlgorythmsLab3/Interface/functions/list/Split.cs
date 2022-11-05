using System;
using AlgorythmsLab3.Structures.LinkedList;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Interface.functions.list
{
    public class Split : ListMenuItem
    {
        public Split(LinkedList<int> list, bool isSelected = false) : base(list, title: "Разделение списка на два по заданному числу", isSelected)
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

                var (list1, list2) = List.Split(value);
                Console.WriteLine("Результат разделения списка:");
                Console.WriteLine(list1);
                Console.WriteLine(list2);
            }
            else
            {
                Console.WriteLine("Введенное значение не является целым числом");
            }

            ConsoleUtil.Pause();
        }
    }
}