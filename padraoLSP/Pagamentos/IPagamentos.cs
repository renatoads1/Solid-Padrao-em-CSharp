using System;
using System.Collections.Generic;
using System.Text;

namespace padraoLSP.Pagamentos
{
    interface IPagamentos
    {
        void ValidarCartao();
        void ConfirmarPagamento();
    }
}
