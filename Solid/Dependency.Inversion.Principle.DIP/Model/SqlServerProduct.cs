namespace Dependency.Inversion.Principle.DIP.Model;

public class SqlServerProduct: IDbProduct
{
    public string GetById(long id)
    {
        return $"SQL -  Product {id}";
    }
}
