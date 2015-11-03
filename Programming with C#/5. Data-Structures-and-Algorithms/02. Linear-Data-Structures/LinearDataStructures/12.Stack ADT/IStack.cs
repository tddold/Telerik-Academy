namespace _12.Stack_ADT
{
    public interface IStack<T>
    {
        void Push(T value);

        T Peek();

        T Pop();

        void Cleare();
    }
}
