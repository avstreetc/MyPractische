using _3.Interfac;


namespace _3.Docum
{
    internal class Subscriber : IObserver
    {
        private string _name;

        public Subscriber(string name)
        {
            _name = name;
        }
        public void WhenSubscribing(Photographer photographer) => Console.WriteLine($"Подписчик {_name} подписался на блогера: {photographer.Name} ");

        public void WhenUnsubscribing(Photographer photographer) => Console.WriteLine($"Подписчик {_name} отписался от блогера: {photographer.Name}");

        public void Update(Photo photo)
        {
            Console.WriteLine($"Подписчик {_name} был уведомлен об выходе фотосессии " +
                $"под названием {photo.Name} " +
                $"от фотографа {photo.Author.Name}");
        }

    }
}
