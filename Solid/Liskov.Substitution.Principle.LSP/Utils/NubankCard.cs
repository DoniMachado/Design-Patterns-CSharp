namespace Liskov.Substitution.Principle.LSP.Utils;

public abstract class NubankCard : IPaymentIntrument
{
    public virtual void CollectPayment()
    {
        Console.WriteLine("Pagamento realizado");
    }

    public virtual void Validate()
    {
        Console.WriteLine("Validação básica");
    }
}
