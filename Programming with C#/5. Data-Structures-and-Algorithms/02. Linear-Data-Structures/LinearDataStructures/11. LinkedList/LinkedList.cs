namespace _11.LinkedList
{
    using System.Collections;

    public class LinkedList<T> : IEnumerable
    {
        private ListNode<T> firstElement;

        public LinkedList()
        {
            this.FirstElement = null;
        }

        public ListNode<T> FirstElement
        {
            get
            {
                return this.firstElement;
            }

            set
            {
                this.firstElement = value;
            }
        }

        public int Count { get; set; }

        public void AddFirst(T value)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListNode<T>(value);
            }
            else
            {
                var newItem = new ListNode<T>(value);
                newItem.Next = this.FirstElement;
                this.firstElement = newItem;
            }

            this.Count++;
        }

        public void AddLast(T value)
        {
            if (this.firstElement == null)
            {
                this.firstElement = new ListNode<T>(value);
            }
            else
            {
                var newItem = this.FirstElement;

                while (newItem.Next != null)
                {
                    newItem = newItem.Next;
                }

                newItem.Next = new ListNode<T>(value);
            }

            this.Count++;
        }

        public void RemoveFirst()
        {
            this.FirstElement = this.FirstElement.Next;
            this.Count--;
        }

        public void RemoveLast()
        {
            var newItem = this.FirstElement;

            while (newItem.Next != null)
            {
                newItem = newItem.Next;
            }

            this.Remove(newItem.Value);
            newItem.Next = null;
        }

        public void Remove(T value)
        {
            var newItem = this.FirstElement;

            if (newItem.Value.Equals(value))
            {
                newItem = null;
                this.FirstElement = this.firstElement.Next;

                return;
            }

            while (newItem != null && newItem.Next != null)
            {
                if (newItem.Next.Value.Equals(value))
                {
                    if (newItem.Next.Next != null)
                    {
                        newItem.Next = newItem.Next.Next;
                    }
                    else
                    {
                        newItem.Next = null;
                    }

                    this.Count--;
                }

                newItem = newItem.Next;
            }
        }

        public void Clear()
        {
            this.FirstElement = null;
            this.FirstElement.Next = null;
            this.Count = 0;
        }

        public bool Contains(T item)
        {
            var newItem = this.FirstElement;
            while (newItem != null)
            {
                if (newItem.Value.Equals(item))
                {
                    return true;
                }

                newItem = newItem.Next;
            }

            return false;
        }

        public IEnumerator GetEnumerator()
        {
            var newItem = this.FirstElement;

            while (newItem != null)
            {
                yield return newItem.Value;
                newItem = newItem.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
