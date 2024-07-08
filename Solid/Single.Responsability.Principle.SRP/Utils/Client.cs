namespace Single.Responsability.Principle.SRP.Utils;

public class Client
{
    public string Nome { get; }
    public string Identificador { get; }

    public Client(string nome, string identificador)
    {
        Nome = nome;
        Identificador = identificador;
    }


    public void CreateClient()
    {
        Console.WriteLine("Faz alguma coisa para criar o cliente");
    }

    public void CreateClient(string nome, string identificador)
    {
        Console.WriteLine("Faz alguma coisa para criar o cliente");
    }

    public void AlterClient(string nome, string identificador)
    {
        Console.WriteLine("Faz alguma coisa para alterar o cliente");
    }

    public void DeleteClient() {
        Console.WriteLine("Faz alguma coisa para deletar o cliente");
    }

    public Client GetClient()
    {
        Console.WriteLine("Faz alguma coisa para ler (get) o cliente");
        return this;
    }

}
