using Dependency.Inversion.Principle.DIP.Model;
using System.Configuration;

namespace Dependency.Inversion.Principle.DIP.Factory;

public class DbProductFactory
{
    public static IDbProduct Create()
    {
        if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
        {

            return new SqlServerProduct();
        }
        else
        {
            return new MongoDBProduct();
        }
    }
}
