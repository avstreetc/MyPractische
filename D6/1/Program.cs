using System;

class a1
{
    static void Main(string[] args)
    {
        Console.Write("Введите арифметическое выражение: ");
        string expression = Console.ReadLine();

        bool isBalanced = CheckBrackets(expression);

        if (isBalanced)
        {
            Console.WriteLine("Скобки в выражении расставлены правильно.");
        }
        else
        {
            Console.WriteLine("Скобки в выражении расставлены неправильно.");
        }
    }

    static bool CheckBrackets(string expression)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in expression)
        {
            if (ch == '(')
            {
                stack.Push(ch);
            }
            else if (ch == ')')
            {
                if (stack.Count == 0)
                {
                    return false; // если нашли закрывающую скобку, когда стек пустой, то выражение неправильно
                }
                else
                {
                    stack.Pop(); // если нашли закрывающую скобку и в стеке есть открывающая скобка, то удаляем её из стека
                }
            }
        }

        return (stack.Count == 0); // если в конце работы со стеком он оказался пустым, то скобки расставлены правильно
    }
}