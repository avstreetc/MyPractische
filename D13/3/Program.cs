using _3.Docum;

Photographer photographer = new Photographer("Avstreetc");

Subscriber subscriber = new Subscriber("Steve");
Moderator moderator = new Moderator("1234");

photographer.Attach(subscriber);
photographer.Attach(moderator);

photographer.CreateNewPhoto("Сделаю ваш момент в фотографии");

photographer.Detach(subscriber);

photographer.CreateNewPhoto("Фотографирую");