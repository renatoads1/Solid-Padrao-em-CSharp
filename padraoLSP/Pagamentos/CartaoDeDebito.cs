using System;
using System.Collections.Generic;
using System.Text;

namespace padraoLSP.Pagamentos
{
    class CartaoDeDebito : CartaoRenato
    {
        public override void ValidarCartao()
        {
            Console.WriteLine("Verificando Saldo");
            Console.WriteLine("Saldo ok !!!!! ");
        }
    }
}
