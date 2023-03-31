class a1
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();
        string output = RemoveBackspaces(input);
        Console.WriteLine(output);
    }

    static string RemoveBackspaces(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '#' && stack.Count > 0)
            {
                stack.Pop();
            }
            else if (c != '#')
            {
                stack.Push(c);
            }
        }
        char[] result = new char[stack.Count];
        int j = stack.Count;

        while (stack.Count > 0)
        {
            result[--j] = stack.Pop();
        }

        return new string(result, 0, result.Length);
    }
}