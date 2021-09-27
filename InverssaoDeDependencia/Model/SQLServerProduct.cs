using System;
using System.Collections.Generic;
using System.Text;

namespace InverssaoDeDependencia.Model
{
    class SQLServerProduct : DbProduct
    {
        public string GetProductById(string Id) {

            return $"SQLServer: Exibindo dados do produto {Id}.";
        }
    }
}
