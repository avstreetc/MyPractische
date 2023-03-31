using System;
using System.Collections.Generic;

namespace PlansProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект класса Plan с типом данных string
            Plan<string> plans = new Plan<string>();

            // Вводим 3 плана с консоли
            Console.WriteLine("Введите 3 плана:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"План {i + 1}: ");
                string plan = Console.ReadLine();
                plans.AddPlan(plan);
            }

            // Выводим все планы
            plans.ShowAllPlans();

            // Удаляем первый план
            //plans.RemovePlan(0);
            Console.Write("Введите номер плана для удаления: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            plans.RemovePlan(index);

            // Выводим все планы после удаления
            plans.ShowAllPlans();

            // Клонируем объект plans
            Plan<string> clonedPlans = (Plan<string>)plans.Clone();

            // Выводим все планы из клонированного объекта
            Console.WriteLine("Все планы из клонированного объекта:");
            clonedPlans.ShowAllPlans();

            // Очищаем все планы из объекта plans
            plans.ClearPlans();
            Console.WriteLine("Все планы после очистки:");
            // Выводим все планы из объекта plans после очистки
            plans.ShowAllPlans();

            
        }
    }

    public class Plan<T> : ICloneable where T : class
    {
        private List<T?> plans;

        public Plan()
        {
            plans = new List<T?>();
        }

        public void AddPlan(T? plan)
        {
            plans.Add(plan);
        }

        public void RemovePlan(int index)
        {
            plans.RemoveAt(index);
        }

        public void ClearPlans()
        {
            plans.Clear();
        }

        public void ShowAllPlans()
        {
            Console.WriteLine("Все планы на сегодня:");
            for (int i = 0; i < plans.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {plans[i]}");
            }
        }
        public object Clone()
        {
            Plan<T> clonedPlan = new Plan<T>();
            foreach (T? plan in plans)
            {
                clonedPlan.AddPlan(plan);
            }
            return clonedPlan;

        }
    }
}
