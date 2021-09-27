using padraoLSP.Pagamentos;
using System;

namespace padraoLSP
{
    class Program
    {
        static void Main(string[] args)
        {
            //CartaoDeCredito ccard = new CartaoDeCredito();
            //CartaoDeDebito dcard = new CartaoDeDebito();
            CRenatoPontos card = new CRenatoPontos();
            //dcard.ValidarCartao();
            //ccard.ValidarCartao();
            card.ValidarCartao();
            card.ConfirmarPagamento();
            Console.ReadKey();
        }
    }
}
