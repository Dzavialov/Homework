namespace StackGeneric
{
    internal interface IGenericStack<TElement>
    {
        void Push(TElement element);
        TElement Pop();
        void Clear();
        int Count();
        TElement Peek();
        void CopyTo(TElement[] array);
    }
}
