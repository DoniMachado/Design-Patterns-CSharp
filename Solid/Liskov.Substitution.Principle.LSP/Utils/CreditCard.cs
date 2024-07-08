namespace Liskov.Substitution.Principle.LSP.Utils;

public class CreditCard: NubankCard
{
    public override void CollectPayment()
    {
        Console.WriteLine("Pagamento realizado - CreditCard");
    }

    public override void Validate()
    {
        Console.WriteLine("Validação básica - CreditCard");
    }
}
