namespace GenericList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GenericList<T> : IEnumerable<T> // where T : IComparable
    {
        // Constant Fields
        private const int DefautCapacity = 8;

        // Array of elements
        private T[] elements;

        // Constructor
        public GenericList()
        {
            this.elements = new T[DefautCapacity];
            this.Capacity = DefautCapacity;
        }

        public GenericList(int capacity)
            : this()
        {
            this.Count = 0;
            this.Capacity = capacity;
        }

        // Properties
        public int Count { get; private set; }

        public int Capacity { get; private set; }

        //Indexer
        public T this[int index]
        {
            get
            {
                if (index < 0 || index > this.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range!");
                }

                return this.elements[index];
            }

            set
            {
                this.elements[index] = value;
            }
        }

        // Methods
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.elements[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public T Min()
        {
            return this.MinMax(false);
        }

        public T Max()
        {
            return this.MinMax(true);
        }

        public void Add(T element)
        {
            if (this.Count == this.Capacity)
            {
                this.Resaize();
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException("Invalid index - Out of range");
            }

            for (int i = index; i < this.Count; i++)
            {
                this.elements[i] = this.elements[i + 1];
                this.elements[i + 1] = default(T);
            }

            this.Count--;
        }

        public void InsertOf(T element, int index)
        {
            for (int i = this.Count - 1; i >= index; i--)
            {
                if (this.Count == this.Capacity)
                {
                    this.Resaize();
                }

                this.elements[i + 1] = this.elements[i];
            }

            this.elements[index] = element;
            this.Count++;
        }

        public void Clear()
        {
            this.elements = new T[DefautCapacity];
            this.Capacity = DefautCapacity;
            this.Count = 0;
        }

        public bool Contain(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public override string ToString()
        {
            if (this.Count == 0)
            {
                return string.Empty;
            }

            return string.Join(", ", this.elements);
        }

        // Private methods
        private void Resaize()
        {
            int newSize = this.Capacity * 2;
            T[] newElements = new T[newSize];

            for (int i = 0; i < this.Count; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
            this.Capacity = newSize;
        }

        private T MinMax(bool value)
        {
            T best = this.elements[0];

            for (int i = 1; i < this.Count; i++)
            {
                if (value)
                {
                    if (best < (dynamic)this.elements[i])
                    {
                        best = this.elements[i];
                    }
                }
                else
                {
                    if (best > (dynamic)this.elements[i])
                    {
                        best = this.elements[i];
                    }
                }
            }

            return best;
        }
    }
}
