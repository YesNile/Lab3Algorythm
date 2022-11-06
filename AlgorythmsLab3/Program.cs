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
            
            // Tests();
        }

        private static void Tests()
        {
            //Тестирование рандомных команд с чтением из файла
            
            AlgorythmsLab3.Testing.Testing.TestQueueRandomInFile(func: x => TestQueue.TestingQueueFile(x),
                name: "Рандомные команды из файла (Очередь)",
                iterCount: 1);
            AlgorythmsLab3.Testing.Testing.TestStackRandomInFile(func: x => TestStack.TestingStackFile(x),
                name: "Рандомные команды из файла (Стэк)",
                iterCount: 1);
            
            
            //Тестирование рандомных команд
            
            AlgorythmsLab3.Testing.Testing.TestStackRandom(func: x => TestStack.TestingStack(x), name: "Рандомные команды (Стэк)",
                iterCount: 1);
            AlgorythmsLab3.Testing.Testing.TestStackSpecificCommands(x => TestStack.TestingStack(x), name: "Pop Push (Стэк)",
                iterCount: 1, 1, 2);
            AlgorythmsLab3.Testing.Testing.TestSharpQueueRandom(func: x => TestQueue.TestingQueueSharpRandom(x),
                name: "Рандомные команды (Queue)",
                iterCount: 1);
            
            //Тестирование константных команд
            
            AlgorythmsLab3.Testing.Testing.TestQueueRandom(func: x => TestQueue.TestingQueue(x), name: "Рандомные команды (Очередь)",
                iterCount: 1);
            AlgorythmsLab3.Testing.Testing.TestQueueSpecificCommands(func: x => TestQueue.TestingQueue(x),
                name: "Enqueue Decueue (Очередь)", iterCount: 1, 1, 2);
            AlgorythmsLab3.Testing.Testing.TestQueueConst(func: x => TestQueue.TestingQueue(x),
                name: "Одинаковые по длине рандомные команды (Очередь)", iterCount: 1);
        }
    }
}