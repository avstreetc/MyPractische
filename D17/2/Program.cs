using FlowersLibrary;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите название цветка:");
        string name = Console.ReadLine();

        Console.Write("Введите температуру, при которой нормально растет цветок:");
        int temperature = int.Parse(Console.ReadLine());

        Flower flower = new Flower(name, temperature);
        FlowerType flowerType = flower.GetFlowerType();

        Console.WriteLine($"Цветок {flower.Name} относится к типу {flowerType}");
    }
}