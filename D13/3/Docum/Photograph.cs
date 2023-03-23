using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Docum
{
    internal class Photograph
    {
        delegate void UpdatePhotograph(Photo photo);
        event UpdatePhotograph? ub;

        private string _name;

        public string Name { get => _name; }

        public Photograph(string name)
        {
            _name = name;
        }

        public void Attach(IObserver observer)
        {
            ub += observer.Update;
            observer.WhenSubscribing(this);
        }

        public void Detach(IObserver observer)
        {
            ub -= observer.Update;
            observer.WhenUnsubscribing(this);
        }

        public void Notify(Photo photo)
        {
            ub?.Invoke(photo);
        }

        public void CreateNewVideo(string namePhoto)
        {
            Photo photo = new Photo()
            {
                Author = this,
                Name = namePhoto
            };
            Notify(photo);
        }
    }
}

