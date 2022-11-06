using AlgorythmsLab3.Interface;
using AlgorythmsLab3.Testing;

namespace AlgorythmsLab3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu menu = new MainMenu();
            menu.Start();
            
            //Тестирование рандомных команд с чтением из файла
            
            // Testing.Testing.TestQueueRandomInFile(func: x => TestQueue.TestingQueueFile(x),
            //     name: "Рандомные команды из файла (Очередь)",
            //     iterCount: 1);
            // Testing.Testing.TestStackRandomInFile(func: x => TestStack.TestingStackFile(x),
            //     name: "Рандомные команды из файла (Стэк)",
            //     iterCount: 1);
            
            
            //Тестирование рандомных команд
            
            // Testing.Testing.TestStackRandom(func: x => TestStack.TestingStack(x), name: "Рандомные команды (Стэк)",
            //     iterCount: 1);
            // Testing.Testing.TestStackSpecificCommands(x => TestStack.TestingStack(x), name: "Pop Push (Стэк)",
            //     iterCount: 1, 1, 2);
            // Testing.Testing.TestSharpQueueRandom(func: x => TestQueue.TestingQueueSharpRandom(x),
            //     name: "Рандомные команды (Queue)",
            //     iterCount: 1);
            
            //Тестирование константных команд
            // Testing.Testing.TestQueueRandom(func: x => TestQueue.TestingQueue(x), name: "Рандомные команды (Очередь)",
            //     iterCount: 1);
            // Testing.Testing.TestQueueSpecificCommands(func: x => TestQueue.TestingQueue(x),
            //     name: "Enqueue Decueue (Очередь)", iterCount: 1, 1, 2);
            // Testing.Testing.TestQueueConst(func: x => TestQueue.TestingQueue(x),
            //     name: "Одинаковые по длине рандомные команды (Очередь)", iterCount: 1);
        }
    }
}