using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Docum
{
    internal class Moder : IObserver
    {
        private string _id;

        public Moderator(string id)
        {
            _id = id;
        }

        public void WhenSubscribing(Photographer photographer) => Console.WriteLine($"Модератор под id: {_id} прикреплен к фотографу: {photographer.Name} ");

        public void WhenUnsubscribing(Photographer photographer) => Console.WriteLine($"Модератор под id: {_id} откреплен от фотограф: {photographer.Name}");

        public void Update(Photo photo)
        {
            Console.WriteLine($"Модератор под id: {_id} был уведомлен о новой фотосессии " +
                $"под названием {photo.Name} " +
                $"от фотографа {photo.Author.Name}");
        }
    }
