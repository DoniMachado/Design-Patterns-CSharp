
using Single.Responsability.Principle.SRP.Utils;

Console.WriteLine("Hello, World!");


Client c = new("Algum nome", "Algum identificador");
Notify notify = new(c);

notify.NotifyClient();
