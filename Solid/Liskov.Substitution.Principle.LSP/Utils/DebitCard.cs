namespace Liskov.Substitution.Principle.LSP.Utils;

public class DebitCard: NubankCard
{
    public override void CollectPayment()
    {
        Console.WriteLine("Pagamento realizado - DebitCard");
    }

    public override void Validate()
    {
        Console.WriteLine("Validação básica - DebitCard");
    }
}
