
static class MyListExtensions
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        T[] array = new T[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            array[i] = list[i];
        }
        return array;
    }
}

class MyList<T>
{
    private List<T> list;

    // Конструктор класса MyList, инициализирующий новый экземпляр списка List<T> 
    public MyList()
    {
        list = new List<T>();
    }

    // доавляем новый элемент в список list 
    public void Add(T item)
    {
        list.Add(item);
    }

    // индексатор для получение элемента
    public T this[int index]
    {
        get { return list[index]; }
    }

    //общее количество элементов
    public int Count
    {
        get { return list.Count; }
    }
}

class a1
{
    static void Main(string[] args)
    {
        MyList<int> list = new MyList<int>(); // экземпляр класса 

        list.Add(10);
        list.Add(20); // добавляем элементы int ибо int
        list.Add(30);

        int[] array = list.GetArray();
        foreach (int item in array)
        {
            Console.WriteLine("Элементы массива, возвращаемые GetArray: " + item);
        }
        Console.WriteLine("Количество элементов в списке: " + list.Count);
    }
}
