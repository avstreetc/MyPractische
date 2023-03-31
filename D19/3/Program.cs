///<summary> 
/// Выполняет конвертацию длины отрезка в метры в зависимости от выбранной длинны
/// </summary>
namespace z3
{
    class Claass
    {
        static void Main()
        {
            //  номер длины
            Console.Write("Введите номер единицы длины, где : 1 — дециметр, " +
                "2 — километр, 3 — метр, 4 — миллиметр, 5 — сантиметр : ");
            int unit = int.Parse(Console.ReadLine());

            //  длину L
            Console.Write("Введите длину отрезка L: ");
            double length = double.Parse(Console.ReadLine());

            /// <summary> Перевод длинны через конструкцию switch </summary>
            bool Ok = true;
            double lengthInMeters = 0;
            switch (unit)
            {
                case 1:
                    // дециметр
                    lengthInMeters = length / 10;
                    break;
                case 2:
                    // километр
                    lengthInMeters = length * 1000;
                    break;
                case 3:
                    //метр
                    lengthInMeters = length;
                    break;
                case 4:
                    //миллиметр
                    lengthInMeters = length / 1000;
                    break;
                case 5:
                    //сантиметр
                    lengthInMeters = length / 100;
                    break;
                default:
                    Ok = false;
                    Console.WriteLine("Неверный номер единицы длины");
                    return;
            }

            /// <summary> Вывод информации, если введена корректная информация </summary>
            if (Ok)
                Console.WriteLine("Длина отрезка в метрах: " + lengthInMeters);
            else Console.WriteLine("Неверный номер единицы длины");
        }
    }
}