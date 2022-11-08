using System.IO;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Testing
{
    public class TestQueue
    {
        //2 часть 2 задание
        public static Queue<object> TestingQueueFile(string fileName)
        {
            var path = Path.GetFullPath(Directory.GetCurrentDirectory() + $"\\..\\..\\..\\Testing\\{fileName}");
            using StreamReader stream = new StreamReader(path);
            var text = stream.ReadToEnd();
            var queue = CommandUtil.GetCommandForQueue(text);
            return queue;
        }

        public static Queue<object> TestingQueue(string command)
        {
            //получение комманд
            var queue = CommandUtil.GetCommandForQueue(command);
            return queue;
        }

        public static System.Collections.Generic.Queue<object> TestingQueueSharpRandom(string command)
        {
            //различные по длине
            var queue = CommandUtil.GetCommandForSharpQueue(command);
            return queue;
        }
    }
}