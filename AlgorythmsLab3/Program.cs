﻿using System;
using System.IO;
using AlgorithmsLab3;
using AlgorythmsLab3.Interface;
using AlgorythmsLab3.Tester;

namespace AlgorythmsLab3
{
    class Program
    {
        public static void Main(string[] args)
        {

            Menu menu = new MainMenu();
            menu.Start();
        }
        

        private static string ReadFile(string fileName) => File.ReadAllText($"..\\..\\..\\..\\{fileName}");

        private static void Task2Stack(Stack<object> stack)
        {
            string str = File.ReadAllText("input.txt");
            string[] elem = str.Split(' ');
          
            foreach (var item in elem)
            {
                if (item.StartsWith("1,"))
                {
                    var newElement = item.Substring(2);
                    stack.Push(newElement);
                    Console.WriteLine($"Добавили элемент {newElement}!");
                }
                else if (item == "2")
                {
                    var lookElement = stack.Pop();
                    Console.WriteLine($"Попнули элемент {lookElement}!");
                }
                else if (item == "3")
                {
                    var lookElement = stack.Top();
                    Console.WriteLine($"Просмотрели элемент {lookElement}!");
                }
                else if (item == "4")
                {
                    Console.WriteLine($"Пустой ли стек? {(stack.IsEmpty() ? "да" : "нет")}");
                }
                else
                {
                    Console.WriteLine($"Просмотрели элементы стека {stack}");
                }
            }
        }

        
        private static void Task2Queue()
        {
            string str = File.ReadAllText("input.txt");
            string[] elem = str.Split(' ');
            Queue<string> queue = new Queue<string>();
            foreach (var item in elem)
            {
                if (item.StartsWith("1,"))
                {
                    var newElement = item.Substring(2);
                    queue.Enqueue(newElement);
                    Console.WriteLine($"Добавили элемент {newElement}!");
                }
                else if (item == "2")
                {
                    var lookElement = queue.Dequeue();
                    Console.WriteLine($"Попнули элемент {lookElement}!");
                }
                else if (item == "3")
                {
                    var lookElement = queue.First();
                    Console.WriteLine($"Просмотрели элемент {lookElement}!");
                }
                else if (item == "4")
                {
                    Console.WriteLine($"Пустая ли очередь? {(queue.IsEmpty() ? "да" : "нет")}");
                }
                else
                {
                    Console.WriteLine($"Просмотрели элементы очереди {queue}");
                }
            }
        }
        private static void TestStackRandom(Func<string, Stack<object>> func, string name, int iterCount)
        {
            var tester = new TimeTester();
            for (int i = 1; i <= 1500; i++)
            {
                var command = Generator.GenerateFile(i);
                Console.WriteLine("Тест алгоритма: {0} | Итерация: {1}", name, i);
                tester.Test(() => func.Invoke(command), iterCount, name);
            }

            tester.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), name + " - время");
            tester.AllResults.Clear();
        }

        private static void TestQueueRandom(Func<string, Queue<object>> func, string name, int iterCount)
        {
            var tester = new TimeTester();
            for (int i = 1; i <= 2000; i++)
            {
                var command = Generator.GenerateFile(i);
                Console.WriteLine("Тест алгоритма: {0} | Итерация: {1}", name, i);
                tester.Test(() => func.Invoke(command), iterCount, name);
            }

            tester.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), name + " - время");
            tester.AllResults.Clear();
        }

        private static void TestQueueConst(Func<string, Queue<object>> func, string name, int iterCount)
        {
            const int MAX_COMANDS = 20;
            var tester = new TimeTester();
            for (int i = 1; i <= 20000; i++)
            {
                var command = Generator.GenerateFile(MAX_COMANDS);
                Console.WriteLine("Тест алгоритма: {0} | Итерация: {1}", name, i);
                tester.Test(() => func.Invoke(command), iterCount, name);
            }

            tester.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), name + " - время");
            tester.AllResults.Clear();
        }
    }
}