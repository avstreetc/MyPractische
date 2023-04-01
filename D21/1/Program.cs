using System;

// Интерфейс стратегии
interface IStrategy
{
    void Execute();
}

// Конкретная стратегия 1
class ConcreteStrategy1 : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Выполняется стратегия 1");
    }
}

// Конкретная стратегия 2
class ConcreteStrategy2 : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Выполняется стратегия 2");
    }
}

// Контекст
class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy)
    {
        this._strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        _strategy.Execute();
    }

    public void SetStrategy(IStrategy strategy)
    {
        this._strategy = strategy;
    }
}

// Пример использования паттерна
class Program
{
    static void Main(string[] args)
    {
        // Создаем объекты стратегий
        IStrategy strategy1 = new ConcreteStrategy1();
        IStrategy strategy2 = new ConcreteStrategy2();

        // Создаем объект контекста и передаем ему первую стратегию
        Context context = new Context(strategy1);

        // Выполняем стратегию 1
        context.ExecuteStrategy();

        // Меняем стратегию на вторую и выполняем ее
        context.SetStrategy(strategy2);
        context.ExecuteStrategy();
    }
}
