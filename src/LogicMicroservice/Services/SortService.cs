using System.Collections;
using System.Diagnostics;

namespace LogicMicroservice.Services
{
    public class SortService : ISortService
    {
        public MyList<int> BubbleSort(MyList<int> data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length - i - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
            return data;
        }
        // да простят меня сенсеи
        public class MyList<T> : IEnumerable
        {
            private T[] _data;
            private int _length;
            public int Length
            {
                get { return _length; }
                private set { _length = value; }
            }

            public T this[int index]
            {
                get => _data[index];
                set => _data[index] = value;
            }

            public MyList()
            {
                _length = 0;
                _data = new T[_length];
            }
            public MyList(T[] items)
            {

                this._data = items;
                Length = _data.Length;

            }
            public void Add(T item)
            {
                int count = _length + 1;
                T[] newData = new T[count];
                if (_length != 0)
                {
                    for (int i = 0; i < _length; i++)
                    {
                        newData[i] = _data[i];
                    }
                }

                _data = newData;
                _data[_length++] = item;
            }
            public T GetValue(int index)
            {
                if (index < 0 || index >= Length)
                    throw new IndexOutOfRangeException();
                return _data[index];
            }

            public IEnumerator GetEnumerator()
            {
                return _data.GetEnumerator();
            }
        }
    }
}
