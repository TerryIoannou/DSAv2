using System.Collections;

public class MyArrayList<T> : IEnumerable<T> where T : IComparable<T>
{
    private List<T> list;

    public MyArrayList()
    {
        list = new List<T>();
    }

    public int Count => list.Count;

    public void Add(T item)
    {
        list.Add(item);
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= list.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            return list[index];
        }
        set
        {
            if (index < 0 || index >= list.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            list[index] = value;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        return list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
