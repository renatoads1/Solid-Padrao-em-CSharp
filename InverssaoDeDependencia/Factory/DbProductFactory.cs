using InverssaoDeDependencia.Model;
using System.Configuration;

namespace InverssaoDeDependencia.Factory
{
    class DbProductFactory
    {
        public static DbProduct Create() {

            if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER") {
                return new SQLServerProduct();
            } else
            { 
                return new MongoDbProduct();
            }
        }
    }
}
