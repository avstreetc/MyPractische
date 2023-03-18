using System;
using System.Text;

//enum Post
//{
//    Фотограф = 10,
//    Программист = 15,
//    Дизайнер = 20,
//    Рабочий = 50

//}


// Worker содержит ФИ работника, название должн и год пост на работу
struct WORKER
{
    public string Name; //Фамилия работника
    public string post; // Позиция должности
    public int YearOfEmployment; //Год работы
    //public int BonusTime; //дополнительные часы в месяц
}
// логика на выполнение бонус зарплаты
//class Accountant
//{
//    public bool AskForBonus(WORKER worker, int hours)
//    {

//        if (hours > worker.BonusTime)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//}


class Program
{
    static void Main(string[] args)
    {
        const int NUM_WORKERS = 3; //количество работников
        WORKER[] workers = new WORKER[NUM_WORKERS]; //массив работников

        // Ввод данных для каждого сотрудника
        for (int i = 0; i < NUM_WORKERS; i++)
        {
            Console.WriteLine("Введите данные работника " + (i + 1) + ":");
            Console.Write("Фамилия Имя: ");
            workers[i].Name = Console.ReadLine();  //Идёт в имя
            Console.Write("Должность: ");
            workers[i].post = Console.ReadLine();
            //foreach (Post post in Enum.GetValues(typeof(Post)))
            //{
            //    Console.Write("{0}, ", post);
            //}
            //Console.WriteLine("):");
            //workers[i].post = (Post)Enum.Parse(typeof(Post), Console.ReadLine());
            Console.Write("Год поступления на работу: ");
            workers[i].YearOfEmployment = int.Parse(Console.ReadLine()); // Идёт в Год Работы
            ////второе задание          
            //Console.Write("Дополнительные часы работы в месяц: ");
            //workers[i].BonusTime = int.Parse(Console.ReadLine()); //Идёт в бонус
            Console.WriteLine(); //для красоты пустое пространство
        }

        // Сортировка массива по алфавиту Имени
        Array.Sort(workers, delegate (WORKER x, WORKER y)
        {
            return x.Name.CompareTo(y.Name);
        });

        // Выводим сортированный массив
        Console.WriteLine("Сортированные данные:");
        for (int i = 0; i < workers.Length; i++)  // или (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Фамилия Имя: " + workers[i].Name + ", Должность: " + workers[i].post + ", Год поступления: " + workers[i].YearOfEmployment);
        }

        Console.WriteLine(); //просто так
        Console.Write("Введите стаж для просмотра превышающего значения: ");
        int minYears = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // Проверка стажа больше чем minYears
        bool workerFound = false;
        for (int i = 0; i < workers.Length; i++)
        {
            int yearsOfEmployment = DateTime.Now.Year - workers[i].YearOfEmployment;
            if (yearsOfEmployment > minYears)
            {
                Console.WriteLine(workers[i].Name + " имеет стаж работы " + yearsOfEmployment + " лет.");
                workerFound = true;
            }
        }
        if (!workerFound)
        {
            Console.WriteLine("Нет работников со стажем больше, чем " + minYears + " лет.");
        }

        //Accountant accountant = new Accountant();
        //Console.WriteLine(); //для красоты пустое пространство
        //Console.Write("Введите от скольких бонусных часов в месяц назначать премию: ");
        //int hour = int.Parse(Console.ReadLine()); //ввод числа от скольких назначать бонус

        //for (int i = 0; i < workers.Length; i++)
        //{
        //    if (accountant.AskForBonus(workers[i].post, hour))  //поменять количество времени
        //    {
        //        Console.WriteLine(workers[i].Name + " заслуживает примею.");
        //    }
        //}
    }
}