using System;

Photograph photograph = new photograph("Avstreetc");

Subscriber subscriber = new Subscriber("Steve");
Moderator moderator = new Moderator("1234");


Photograph.Attach(subscriber);
Photograph.Attach(moderator);

Photograph.CreateNewVideo("Сделаю ваш момент в фотографии");

Photograph.Detach(subscriber);

Photograph.CreateNew("Фотографирую");