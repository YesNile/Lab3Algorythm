using System;
using AlgorythmsLab3.Structures.LinkedList;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Interface.functions.list
{
    public class Swap : ListMenuItem
    {
        public Swap(LinkedList<int> list, bool isSelected = false) : base(list, title: "Поменять местами два элемента списка", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            Console.WriteLine($"[{Title.ToUpper()}]\n");
            
            Console.WriteLine("Изначальный список:");
            Console.WriteLine(List);

            Console.WriteLine("Введите первое целое число: ");
            Console.CursorVisible = true;

            string input1 = Console.ReadLine();
            
            Console.WriteLine("Введите второе целое число: ");
            string input2 = Console.ReadLine();
            int value1;
            int value2;
            try
            {
                value1 = int.Parse(input1);
                value2 = int.Parse(input2);
            }
            catch (Exception e)
            {
                value1 = -1;
                value2 = -1;
            }

            if (value1 != -1 && value2 != -1)
            {
                Console.CursorVisible = false;

                try
                {
                    List.Swap(value2, value1);
                    Console.WriteLine("Результат смены местами двух элементов:");
                    Console.WriteLine(List);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Введеное значение отсутствует в списке");
                }
            }
            else
            {
                Console.WriteLine("Введенное значение не является целым числом");
            }

            ConsoleUtil.Pause();
        }
    }
}