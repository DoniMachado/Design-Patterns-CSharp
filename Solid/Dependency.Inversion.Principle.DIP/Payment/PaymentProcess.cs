using Dependency.Inversion.Principle.DIP.Factory;
using Dependency.Inversion.Principle.DIP.Model;

namespace Dependency.Inversion.Principle.DIP.Payment;

public class PaymentProcess
{
    public void Pay(long id)
    {
        IDbProduct DbProduct = DbProductFactory.Create();
        var data = DbProduct.GetById(id);
        Console.WriteLine(data);
    }
}
