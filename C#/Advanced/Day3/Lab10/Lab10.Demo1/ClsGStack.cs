namespace Lab10.Demo1
{
    internal class ClsGStack<T>
    {
        T[] _arr;
        int _size;
        int _top;
        private int Size
        {
            get { return _size; }
            set
            {
                if (value > 0)
                    _size = value;
            }
        }

        public ClsGStack()
        {
            Size = 4;
            _arr = new T[Size];
            _top = -1;
        }
        public void Push(T item)
        {
            if (!IsFull())
            {
                _top++;
                _arr[_top] = item;
            }
            else
            {
                Size *= 2;
                T[] arr2 = new T[Size];
                _arr.CopyTo(arr2, 0);
                _arr = arr2;
                Push(item);
            }
        }

        public T Pop()
        {
            if (_top >= 0)
                return _arr[_top--];
            else throw new InvalidOperationException("stack is empty");
        }

        public T Peek()
        {
            if (!IsEmpty())
                return _arr[_top--];
            else throw new InvalidOperationException("stack is empty");
        }

        public bool IsEmpty()
        {
            return _top == -1;
        }

        public bool IsFull()
        {
            return _top == Size - 1;
        }



    }
}
