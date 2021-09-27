using System;
using System.Collections.Generic;
using System.Text;

namespace padraoLSP.Pagamentos
{
    abstract class CartaoRenato : IPagamentos
    {
        public void ConfirmarPagamento()
        {
            Console.WriteLine("Pagamento realizado com sucesso!!!");
        }

        public virtual void ValidarCartao()
        {
            Console.WriteLine("Validando Limite");
            Console.WriteLine("Limite ok !!!!! ");
        }
    }
}
