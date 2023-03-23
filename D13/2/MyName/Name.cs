using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MyName
{
    internal class MyInfo
    {
        // Создаем делегат для определения события изменения информации
        delegate void ChangingInformation();
        // Создаем событие изменения информации
        event ChangingInformation ciEvent;


        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                // Проверяем, изменилось ли значение имени
                if (_name != value)
                {
                    _name = value;
                    ciEvent?.Invoke();
                }
            }
        }

        public MyInfo(string name)
        {
            _name = name;
            // Подписываемся на событие изменения информации и задаем обработчик события
            ciEvent += delegate ()
            {
                Console.WriteLine("Имя изменилось");
            };
        }
    }
}