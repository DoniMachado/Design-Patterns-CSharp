namespace Liskov.Substitution.Principle.LSP.Utils;

public interface IPaymentIntrument
{
    void CollectPayment();

    void Validate();
}
