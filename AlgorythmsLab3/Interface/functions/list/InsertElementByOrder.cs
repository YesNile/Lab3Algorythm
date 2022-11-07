using System;
using System.Linq;
using AlgorythmsLab3.Structures.LinkedList;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Interface.functions.list
{
    public class InsertElementByOrder : MenuItemList
    {
        public InsertElementByOrder(LinkedList<int> list, bool isSelected = false) : base(list,
            title: "Вставить элемент с сохранением порядка", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            Console.WriteLine($"[{Title.ToUpper()}]\n");
            
            var orderedList = List.OrderBy(x => x).ToList();
            var list = new LinkedList<int>(orderedList);
            Console.WriteLine("Изначальный список:");
            Console.WriteLine(list);

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
                value = int.MinValue;
            }

            if (value != int.MinValue)
            {
                Console.CursorVisible = false;

                list.InsertElementByOrder(value);
                Console.WriteLine("Результат вставки элемента с сохранением порядка:");
                Console.WriteLine(list);
            }
            else
            {
                Console.WriteLine("Введенное значение не является целым числом");
            }

            ConsoleUtil.Pause();
        }
    }
}