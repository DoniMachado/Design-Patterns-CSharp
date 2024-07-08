namespace Single.Responsability.Principle.SRP.Utils;

public class Notify
{
    public Client _client { get; }

    public Notify(Client client)
	{
        _client = client;
    }


    public void NotifyClient()
    {
        Console.WriteLine($"Notificando o cliente {_client.Nome}!");
    }

    
}
