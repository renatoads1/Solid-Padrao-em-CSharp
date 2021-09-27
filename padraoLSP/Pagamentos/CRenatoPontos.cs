using System;

namespace padraoLSP.Pagamentos
{
    class CRenatoPontos : IPagamentos
    {
        public void ConfirmarPagamento()
        {
            Console.WriteLine("Pagamento Realizado Com Sucesso");
            Console.WriteLine("Pontuação Creditada");
        }

        public void ValidarCartao()
        {
            Console.WriteLine("Limites ok, Pontos ok");
        }
    }
}
