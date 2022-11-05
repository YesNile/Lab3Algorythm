using System;
using System.Collections.Generic;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Interface.functions.list
{
    public class Concat : ListMenuItem
    {
        public Concat(Structures.LinkedList.LinkedList<int> list, bool isSelected = false) : base(list,
            title: "Дописать новый список в конец существующего", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            Console.WriteLine($"[{Title.ToUpper()}]\n");

            Console.WriteLine("Введите список целых чисел через пробел: ");
            Console.CursorVisible = true;

            string input = Console.ReadLine();
            List<int> list = new List<int>();
            try
            {
                var symbols = input.Split(" ");
                foreach (var s in symbols)
                {
                    int value = int.Parse(s);
                    list.Add(value);
                }
            }
            catch (Exception e)
            {
                
            }
            
            Console.CursorVisible = false;

            Console.WriteLine("\nИзначальный список:");
            Console.WriteLine(List);

            List.Concat(list);
            Console.WriteLine("Результат вставки нового списка:");
            Console.WriteLine(List);

            ConsoleUtil.Pause();
        }
    }
}