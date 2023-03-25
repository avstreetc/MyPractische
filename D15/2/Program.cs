MyDictionary<string, int> dictionary = new MyDictionary<string, int>();
dictionary.Add("one", 1);
dictionary.Add("two", 2);
dictionary.Add("three", 3);
Console.WriteLine(dictionary["two"]); // Выведет 2
Console.WriteLine(dictionary.Count); // Выведет 3


class MyDictionary<TKey, TValue>
{
    private List<TKey> keys; // список ключей
    private List<TValue> values; // список значений

    // Конструктор класса MyDictionary, инициализирующий новые экземпляры списков ключей и значений
    public MyDictionary()
    {
        keys = new List<TKey>();
        values = new List<TValue>();
    }

    // Метод добавления пары элементов
    public void Add(TKey key, TValue value)
    {
        keys.Add(key);
        values.Add(value);
    }

    // Индексатор для получения значения элемента по указанному индексу
    public TValue this[TKey key]
    {
        get
        {
            int index = keys.IndexOf(key);
            if (index == -1)
                throw new KeyNotFoundException(); // генерируем исключение, если ключ не найден
            return values[index];
        }
        set
        {
            int index = keys.IndexOf(key);
            if (index == -1)
                throw new KeyNotFoundException(); // генерируем исключение, если ключ не найден
            values[index] = value;
        }
    }

    // Свойство только для чтения для получения общего количества пар элементов
    public int Count
    {
        get { return keys.Count; }
    }
}

