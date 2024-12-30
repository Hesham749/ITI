namespace Lab10.Demo1
{
    internal class ClsGList<T>
    {
        T[] _arr;
        int _size;
        int _lastIndex;
        private int Size
        {
            get { return _size; }
            set
            {
                if (value > 0)
                    _size = value;
            }
        }

        public ClsGList(int size)
        {
            Size = 4;
            Size = size;
            _arr = new T[Size];
            _lastIndex = -1;
        }
        public void Add(T item)
        {
            if (_lastIndex < Size - 1)
            {
                _lastIndex++;
                _arr[_lastIndex] = item;
            }
            else
            {
                Size *= 2;
                T[] arr2 = new T[Size];
                _arr.CopyTo(arr2, 0);
                _arr = arr2;
                Console.WriteLine(_arr.Length);
                Add(item);
            }
        }

        public void Clear()
        {
            _lastIndex = -1;
        }

        public void Print()
        {
            Console.Write("{");
            for (int i = 0; i <= _lastIndex; i++)
            {
                Console.Write($" {_arr[i]},");
            }
            Console.WriteLine($"{(_lastIndex == -1 ? "" : "\b ")}{"}"}");
        }


        public void Remove(T item)
        {
            for (int i = 0; i <= _lastIndex; i++)
            {
                if (Equals(item, _arr[i]))
                {
                    for (int j = i; j <= _lastIndex; j++)
                    {
                        _arr[j] = _arr[j + 1];
                        _lastIndex--;
                        break;
                    }
                }
            }
        }

    }
}
