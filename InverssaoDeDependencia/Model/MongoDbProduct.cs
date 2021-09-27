using System;
using System.Collections.Generic;
using System.Text;

namespace InverssaoDeDependencia.Model
{
    class MongoDbProduct : DbProduct
    {
        public string GetProductById(string Id)
        {

            return $"MongoDb: Exibindo dados do produto {Id}.";
        }
    }
}
