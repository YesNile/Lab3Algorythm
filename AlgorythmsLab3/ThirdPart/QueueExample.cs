using System.Collections;
using System.Linq;

namespace AlgorythmsLab3.ThirdPart
{
    public class QueueExample
    {
        public static System.Collections.Generic.Queue<T> Example<T>(System.Collections.Generic.Queue<T> firstQueue, System.Collections.Generic.Queue<T> secondQueue)
        {
            System.Collections.Generic.Queue<T> result = new System.Collections.Generic.Queue<T>();
            int index = 0;
            while (index <= secondQueue.Count)
            {
                if (index % 2 != 0) result.Enqueue(firstQueue.ElementAt(index));
                else result.Enqueue(secondQueue.ElementAt(index));
                index++;
            }
            return result;
        }
    }
}