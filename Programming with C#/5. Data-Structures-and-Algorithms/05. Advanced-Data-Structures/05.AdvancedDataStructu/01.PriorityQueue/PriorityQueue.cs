namespace _01.PriorityQueue
{
    using System;
    using System.Text;

    public class PriorityQueue<T> where T : IComparable
    {
        private const int InitialCapacity = 16;

        private T[] heap;
        private int index;

        public PriorityQueue()
        {
            this.heap = new T[InitialCapacity];
            this.index = 1;
        }

        public int Count
        {
            get
            {
                return this.index - 1;
            }
        }

        public void Add(T element)
        {
            this.IncreaseArrayIfNecessary();

            this.heap[this.index] = element;

            int childIndex = this.index;
            int parentIndex = childIndex / 2;
            this.index++;

            while (parentIndex >= 1 && this.heap[childIndex].CompareTo(this.heap[parentIndex]) < 0)
            {
                T swapValue = this.heap[parentIndex];
                this.heap[parentIndex] = this.heap[childIndex];
                this.heap[childIndex] = swapValue;

                childIndex = parentIndex;
                parentIndex = childIndex / 2;
            }
        }

        public T RemoveFirst()
        {
            T result = this.heap[1];

            this.heap[1] = this.heap[this.Count];
            this.index--;

            int rootIndex = 1;
            int minChild;

            while (true)
            {
                int lefChildIndex = rootIndex * 2;
                int rightChildIndex = rootIndex * 2 + 1;

                if (lefChildIndex > this.index)
                {
                    break;
                }

                if (rightChildIndex > this.index)
                {
                    minChild = lefChildIndex;
                }
                else if (this.heap[lefChildIndex].CompareTo(this.heap[rightChildIndex]) < 0)
                {
                    minChild = lefChildIndex;
                }
                else
                {
                    minChild = rightChildIndex;
                }

                if (this.heap[minChild].CompareTo(this.heap[rootIndex]) < 0)
                {
                    T swapValue = this.heap[rootIndex];
                    this.heap[rootIndex] = this.heap[minChild];
                    this.heap[minChild] = swapValue;

                    rootIndex = minChild;
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        public T Peek()
        {
            return this.heap[1];
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 1; i <= this.Count; i++)
            {
                if (i != this.Count)
                {
                    sb.AppendFormat("{0}, ", this.heap[i]);
                }
                else
                {
                    sb.AppendFormat("{0}", this.heap[i]);

                }

            }

            //foreach (var item in this.heap)
            //{
            //    sb.AppendFormat("{0}, ", item);
            //}

            return sb.ToString();
        }

        private void IncreaseArrayIfNecessary()
        {
            if (this.index >= this.heap.Length - 1)
            {
                T[] copiedHeap = new T[this.heap.Length * 2];

                Array.Copy(this.heap, 0, copiedHeap, 0, this.heap.Length);

                this.heap = copiedHeap;
            }
        }
    }
}
