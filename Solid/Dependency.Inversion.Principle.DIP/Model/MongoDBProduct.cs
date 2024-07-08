namespace Dependency.Inversion.Principle.DIP.Model;

public class MongoDBProduct : IDbProduct
{
    public string GetById(long id)
    {
        return $"MongoDB -  Product {id}";
    }
}
