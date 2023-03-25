using _3.Docum;


namespace _3.Interfac
{
    internal interface IObserver
    {
        void Update(Photo photo);
        void WhenSubscribing(Photographer photographer);
        void WhenUnsubscribing(Photographer photographer);
    }
}
