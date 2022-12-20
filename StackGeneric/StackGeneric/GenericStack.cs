using System.Reflection;

namespace StackGeneric
{
    public class GenericStack<TElement> : IGenericStack<TElement>
    {
        private List<TElement> genericStack = new List<TElement>();
        private int topElement = -1;

        public void Push(TElement element)
        {
          topElement++;
          genericStack.Add(element); 
        }
        public TElement Pop()
        {
            TElement elementToRemove;
            if(!(topElement < 0))
            {
                elementToRemove = genericStack[topElement];
                genericStack.RemoveAt(topElement);
                topElement--;
                return elementToRemove;
            }
            else
            {
                throw new StackIsEmptyException();
            }
        }
        public void Clear()
        {
            for(int i = topElement; i >= 0; i--)
            {
                genericStack.RemoveAt(i); 
            }
            topElement = -1;
        }
        public int Count()
        {
            int count = 0;
            foreach(var x in genericStack)
            {
                count++;
            }
            return count;
        }
        public TElement Peek()
        {
            if (!(topElement < 0))
            {
                return genericStack[topElement];
            }
            else
            {
                throw new StackIsEmptyException();
            }
        }   
        public void CopyTo(TElement[] array)
        {
            for(int i = 0; i <= topElement; i++)
            {
                array[i] = genericStack[i];
            }
        }
    }
}
