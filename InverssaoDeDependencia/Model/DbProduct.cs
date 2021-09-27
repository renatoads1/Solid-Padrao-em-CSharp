using System;
using System.Collections.Generic;
using System.Text;

namespace InverssaoDeDependencia.Model
{
    interface DbProduct
    {
       string GetProductById(string Id);
    }
}
