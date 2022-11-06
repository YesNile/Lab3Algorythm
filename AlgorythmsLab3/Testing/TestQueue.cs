using System.IO;
using AlgorythmsLab3.Utils;

namespace AlgorythmsLab3.Testing
{
    public class TestQueue
    {
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
            var queue = CommandUtil.GetCommandForQueue(command);
            return queue;
        }

        public static System.Collections.Generic.Queue<object> TestingQueueSharpRandom(string command)
        {
            var queue = CommandUtil.GetCommandForSharpQueue(command);
            return queue;
        }
    }
}