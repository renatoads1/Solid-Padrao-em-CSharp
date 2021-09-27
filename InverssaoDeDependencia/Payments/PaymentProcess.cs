using InverssaoDeDependencia.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace InverssaoDeDependencia.Payments
{
    class PaymentProcess
    {
        public void Pay(string Id) {

            SQLServerProduct prod = new SQLServerProduct();
            string retornoProduct = prod.GetProductById(Id);
            Console.WriteLine(retornoProduct);
        }
    }
}
