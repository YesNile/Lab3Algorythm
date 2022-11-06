using System;
using System.IO;
using AlgorithmsLab3;
using AlgorythmsLab3.Tester;
using AlgorythmsLab3.Testing.Tester;

namespace AlgorythmsLab3.Testing
{
    public class Testing
    {
        /// <summary>
        /// Тестирование рандомных команд стэка
        /// </summary>
        public static void TestStackRandom(Func<string, Stack<object>> func, string name, int iterCount)
        {
            var tester = new TimeTester();
            var tester2 = new MemoryTester();
            for (int i = 1; i <= 1500; i++)
            {
                var command = Generator.GenerateRandomCommands(i);
                Console.WriteLine($"Тест алгоритма: {name} | Итерация: {i}");
                tester.Test(() => func.Invoke(command), iterCount, name);
                tester2.Test(() => func.Invoke(command), iterCount, name);
            }

            tester.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - время");
            tester.AllResults.Clear();

            tester2.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - память");
            tester2.AllResults.Clear();
        }

        /// <summary>
        /// Тестирование рандомных команд стэка с чтением из файла
        /// </summary>
        public static void TestStackRandomInFile(Func<string, Stack<object>> func, string name, int iterCount)
        {
            var tester = new TimeTester();
            var tester2 = new MemoryTester();
            string path = Directory.GetCurrentDirectory() + "\\..\\..\\..\\Testing\\testStack.txt";
            for (int i = 1; i <= 1500; i++)
            {
                var command = Generator.GenerateRandomCommands(i);
                File.WriteAllText(path, command);
                Console.WriteLine($"Тест алгоритма: {name} | Итерация: {i}");
                tester.Test(() => func.Invoke("testStack.txt"), iterCount, name);
                tester2.Test(() => func.Invoke("testStack.txt"), iterCount, name);

                File.Delete(path);
            }

            tester.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - время");
            tester.AllResults.Clear();

            tester2.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - память");
            tester2.AllResults.Clear();
        }

        /// <summary>
        /// Тестирование конкретно заданных команд стэка
        /// </summary>
        public static void TestStackSpecificCommands(Func<string, Stack<object>> func, string name, int iterCount,
            params int[] commands)
        {
            var tester = new TimeTester();
            var tester2 = new MemoryTester();
            for (int i = 1; i <= 1500; i++)
            {
                var command = Generator.GenerateRandomCommandsByPattern(i, commands);
                Console.WriteLine($"Тест алгоритма: {name} | Итерация: {i}");
                tester.Test(() => func.Invoke(command), iterCount, name);
                tester2.Test(() => func.Invoke(command), iterCount, name);
            }

            tester.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - время");
            tester.AllResults.Clear();

            tester2.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - память");
            tester2.AllResults.Clear();
        }

        /// <summary>
        /// Тестирование рандомных команд очереди
        /// </summary>
        public static void TestQueueRandom(Func<string, Queue<object>> func, string name, int iterCount)
        {
            var tester = new TimeTester();
            var tester2 = new MemoryTester();
            for (int i = 1; i <= 2000; i++)
            {
                var command = Generator.GenerateRandomCommands(i);
                Console.WriteLine($"Тест алгоритма: {name} | Итерация: {i}");
                tester.Test(() => func.Invoke(command), iterCount, name);
                tester2.Test(() => func.Invoke(command), iterCount, name);
            }

            tester.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - время");
            tester.AllResults.Clear();

            tester2.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - память");
            tester2.AllResults.Clear();
        }

        /// <summary>
        /// Тестирование рандомных команд очереди с чтением из файла
        /// </summary>
        public static void TestQueueRandomInFile(Func<string, Queue<object>> func, string name, int iterCount)
        {
            var tester = new TimeTester();
            var tester2 = new MemoryTester();
            string path = Directory.GetCurrentDirectory() + "\\..\\..\\..\\Testing\\testQueue.txt";
            for (int i = 1; i <= 2000; i++)
            {
                var command = Generator.GenerateRandomCommands(i);
                File.WriteAllText(path, command);
                Console.WriteLine($"Тест алгоритма: {name} | Итерация: {i}");
                tester.Test(() => func.Invoke("testQueue.txt"), iterCount, name);
                tester2.Test(() => func.Invoke("testQueue.txt"), iterCount, name);
                File.Delete(path);
            }

            tester.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - время");
            tester.AllResults.Clear();

            tester2.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - память");
            tester2.AllResults.Clear();
        }

        /// <summary>
        /// Тестирование конкретно заданных команд очереди
        /// </summary>
        public static void TestQueueSpecificCommands(Func<string, Queue<object>> func, string name, int iterCount,
            params int[] commands)
        {
            var tester = new TimeTester();
            var tester2 = new MemoryTester();
            for (int i = 1; i <= 2000; i++)
            {
                var command = Generator.GenerateRandomCommandsByPattern(i, commands);
                Console.WriteLine($"Тест алгоритма: {name} | Итерация: {i}");
                tester.Test(() => func.Invoke(command), iterCount, name);
                tester2.Test(() => func.Invoke(command), iterCount, name);
            }

            tester.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - время");
            tester.AllResults.Clear();

            tester2.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - память");
            tester2.AllResults.Clear();
        }

        /// <summary>
        /// Тестирование константных команд очереди
        /// </summary>
        public static void TestQueueConst(Func<string, Queue<object>> func, string name, int iterCount)
        {
            const int maxCommands = 50;

            var tester = new TimeTester();
            var tester2 = new MemoryTester();
            for (int i = 1; i <= 20000; i++)
            {
                var command = Generator.GenerateRandomCommands(maxCommands);
                Console.WriteLine($"Тест алгоритма: {name} | Итерация: {i}");
                tester.Test(() => func.Invoke(command), iterCount, name);
                tester2.Test(() => func.Invoke(command), iterCount, name);
            }

            tester.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - время");
            tester.AllResults.Clear();

            tester2.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - память");
            tester2.AllResults.Clear();
        }

        /// <summary>
        /// Тестирование рандомных команд дефолтной очереди C#
        /// </summary>
        public static void TestSharpQueueRandom(Func<string, System.Collections.Generic.Queue<object>> func,
            string name, int iterCount)
        {
            var tester = new TimeTester();
            var tester2 = new MemoryTester();
            for (int i = 1; i <= 2000; i++)
            {
                var command = Generator.GenerateRandomCommands(i);
                Console.WriteLine($"Тест алгоритма: {name} | Итерация: {i}");
                tester.Test(() => func.Invoke(command), iterCount, name);
                tester2.Test(() => func.Invoke(command), iterCount, name);
            }

            tester.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - время");
            tester.AllResults.Clear();

            tester2.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - память");
            tester2.AllResults.Clear();
        }
    }
}