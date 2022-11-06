using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Testing
{
    public class TestStack
    {
        public static Stack<object> TestingStackFile(string fileName)
        {
            var path = Path.GetFullPath(Directory.GetCurrentDirectory() + $"\\..\\..\\..\\Testing\\{fileName}");
            using StreamReader stream = new StreamReader(path);
            var text = stream.ReadToEnd();
            var stack = CommandUtil.GetCommandForStack(text);
            return stack;
        }

        public static void TestingStackRPN()
        {
            var path = Path.GetFullPath(Directory.GetCurrentDirectory() + "\\..\\..\\..\\Test\\input2.txt");
            if (File.Exists(path))
            {
                using StreamReader stream = new StreamReader(path);
                var text = stream.ReadToEnd();
                List<string> operation = text.Split(" ").ToList().Where(x => !x.Equals(string.Empty)).ToList();
                double result = StackRPN.CalculateRPN(operation);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Отсуствует файл input2.txt в директории с тестами");
            }
        }

        public static void TestingStackParseInRPN()
        {
            string text;
            Console.Write("Напишите выражение: ");
            text = Console.ReadLine();
            string result = StackRPN.ParseInRPN(text);
            Console.WriteLine(result);
        }

        public static Stack<object> TestingStack(string command)
        {
            var stack = CommandUtil.GetCommandForStack(command);
            return stack;
        }

        
    }
}