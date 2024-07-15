namespace Design.Pattern.Criacional.Factory.Method;


public interface ICustomer
{
    void AddPoints();
    void AddDiscount();
}

public class GoldCustomer : ICustomer
{
    public void AddPoints()
    {
        Console.WriteLine("Gold Customer - Points Added");
    }

    public void AddDiscount()
    {
        Console.WriteLine("Gold Customer - Discount Added");
    }

    public void GoldOperation()
    {
        Console.WriteLine("Operation specific to Gold Customer");
    }
}

public class SilverCustomer : ICustomer
{
    public void AddPoints()
    {
        Console.WriteLine("Silver Customer -  Points Added");
    }

    public void AddDiscount()
    {
        Console.WriteLine("Silver Customer - Discount Added");
    }

    public void SilverOperation()
    {
        Console.WriteLine("Operation specific to Silver Customer");
    }
}

public abstract class BaseCustomerFactory
{
    public ICustomer GetCustomer()
    {
        ICustomer myCust = this.CreateCustomer();
        myCust.AddPoints();
        myCust.AddDiscount();
        return myCust;
    }
    public abstract ICustomer CreateCustomer();
}

public class GoldCustomerFactory : BaseCustomerFactory
{
    public override ICustomer CreateCustomer()
    {
        GoldCustomer objCust = new GoldCustomer();
        objCust.GoldOperation();
        return objCust;
    }
}
public class SilverCustomerFactory : BaseCustomerFactory
{
    public override ICustomer CreateCustomer()
    {
        SilverCustomer objCust = new SilverCustomer();
        objCust.SilverOperation();
        return objCust;
    }
}

class MainApp
{
    public static void Main()
    {
        //Client Code
        BaseCustomerFactory c = new GoldCustomerFactory();// Or new SilverCustomerFactory();
        ICustomer objCust = c.GetCustomer();
    }

}

