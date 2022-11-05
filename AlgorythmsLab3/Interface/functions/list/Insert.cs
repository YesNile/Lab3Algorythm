using System;
using System.Drawing;
using AlgorythmsLab3.Structures.LinkedList;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Interface.functions.list
{
    public class Insert : ListMenuItem
    {
        public Insert(LinkedList<int> list, bool isSelected = false) : base(list, title: "Вставить элемент \'F\' перед первым вхождением элемента \'E\'", isSelected)
        {
        }

        public override void Execute()
        {
            ConsoleUtil.ClearScreen();

            Console.WriteLine($"[{Title.ToUpper()}]\n");

            Console.WriteLine("Введите целое число \'F\': ");
            Console.CursorVisible = true;

            string input1 = Console.ReadLine();
            
            Console.WriteLine("Введите целое число \'E\': ");
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

                Console.WriteLine("Изначальный список:");
                Console.WriteLine(List);

                List.Insert(value2, value1);
                Console.WriteLine("Результат вставки элемента \'F\':");
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