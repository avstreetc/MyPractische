using _3.Interfac;

namespace _3.Docum
{
    internal class Photographer 
    {
        delegate void UpdatePhotograph(Photo photo);
        event UpdatePhotograph? ub;

        private string _name;

        public string Name { get => _name; }

        public Photographer(string name)
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

        public void CreateNewPhoto(string namePhoto)
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

