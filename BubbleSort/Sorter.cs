using System;

namespace BubbleSort
{
    public class Sorter
    {
        public int[] Sort(int[] sequence)
        {
            if (sequence == null)
            {
                throw new ArgumentNullException();
            }
            if (sequence.Length <= 1)
            {
                return sequence;
            }
            BubbleSort(sequence);
            return sequence;
        }

        private static void BubbleSort(int[] sequence)
        {
            bool clearRun = false;
            while (!clearRun)
            {
                clearRun = true;
                for (int i = 0; i < sequence.Length - 1; i++)
                {
                    if (sequence[i] > sequence[i + 1])
                    {
                        clearRun = false;
                        int tmp = sequence[i];
                        sequence[i] = sequence[i + 1];
                        sequence[i + 1] = tmp;
                    }
                }
            }
        }
    }
}
