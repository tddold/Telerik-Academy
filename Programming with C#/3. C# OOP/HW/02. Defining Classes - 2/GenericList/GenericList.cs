namespace GenericList
{
    using System;
    using System.Linq;
    using System.Text;

    public class GenericList<T> where T : IComparable
    {
        // Constant Fields
        private const int DefautCapacity = 8;

        // Array of elements
        private T[] elements;

        // Constructor
        public GenericList()
        {
            this.elements = new T[DefautCapacity];
        }

        public GenericList(int capacity = DefautCapacity)
        {
            this.Count = 0;
            this.Capacity = capacity;
        }

        // Properties
        public int Count { get; private set; }

        public int Capacity { get; private set; }

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
        public T Min()
        {
            throw new NotImplementedException();
        }

        public T Max()
        {
            throw new NotImplementedException();
        }
        public void Add(T element)
        {
            if (this.Count ==  this.Capacity)
            {
                this.Resaize(this.Capacity);
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        public void RemoveAt(T element)
        {
            throw new NotImplementedException();
        }
        public void Insert(T element)
        {
            throw new NotImplementedException();
        }
        public void Clear(T element)
        {
            throw new NotImplementedException();
        }

        public void Contains(T element)
        {
            throw new NotImplementedException();
        }

        public void IndexOf(T element)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        // Private methods
        private void Resaize(int capacity)
        {
            throw new NotImplementedException();
        }

        private T MinMax(bool value)
        {
            throw new NotImplementedException();

        }
    }
}
