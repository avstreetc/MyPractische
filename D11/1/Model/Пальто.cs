using a1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a1.Model
{
    internal class Пальто : Одежда
    {
        // Поле - размер V
        protected double V;

        // Конструктор производного класса
        public Пальто(string название, double V) : base(название)
        {
            this.V = V;
        }

        // Переопределяем метод ВывестиРезультат для класса Пальто
        public override void ВывестиРезультат()
        {
            Console.WriteLine("Название: {0}, Размер: {1:F1}, Расход ткани: {2:F1} м.", название, V, РасходТкани());
        }

        // Переопределяем метод РасходТкани для класса Пальто
        public override double РасходТкани()
        {
            return V / 6.5 + 0.5;
        }
    }
}
