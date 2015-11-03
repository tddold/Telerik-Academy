namespace _13.Queue_ADT
{
    public interface IQueue<T>
    {
        void Enqueue(T value);

        T Peek();

        T Dequeue();

        void Clear();
    }
}
