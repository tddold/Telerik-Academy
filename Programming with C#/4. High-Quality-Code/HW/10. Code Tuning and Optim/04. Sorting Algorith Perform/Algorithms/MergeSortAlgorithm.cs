namespace Performance.Algorithms
{
    using System;
    using System.Collections.Generic;

    public class MergeSortAlgorithm<T> : ISorter<T> where T : IComparable
    {
        private T[] temp;

        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Collection cannot be null.");
            }

            this.temp = new T[collection.Count];
            this.Partitioning(collection, 0, collection.Count - 1);
        }

        private void Partitioning(IList<T> collection, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
            {
                return;
            }

            int middlrIndex = (leftIndex + rightIndex) / 2;

            this.Partitioning(collection, leftIndex, middlrIndex);
            this.Partitioning(collection, middlrIndex + 1, rightIndex);

            this.Merge(collection, leftIndex, middlrIndex, rightIndex);
        }

        private void Merge(IList<T> collection, int leftIndex, int middlrIndex, int rightIndex)
        {
            int tempPointer = leftIndex; // using for T[] "temp" array
            int leftPointer = leftIndex;
            int rightPointer = middlrIndex + 1;

            while (leftPointer <= middlrIndex && rightPointer <= rightIndex)
            {
                if (collection[leftPointer].CompareTo(collection[rightPointer]) < 0)
                {
                    this.temp[tempPointer++] = collection[leftPointer++];
                }
                else
                {
                    this.temp[tempPointer++] = collection[rightPointer++];
                }
            }

            while (leftPointer <= middlrIndex)
            {
                this.temp[tempPointer++] = collection[rightPointer++];
            }

            while (rightPointer <= rightIndex)
            {
                this.temp[tempPointer++] = collection[rightPointer++];
            }

            for (int index = leftIndex; index <= rightIndex; index++)
            {
                collection[index] = this.temp[index];
            }
        }
    }
}
