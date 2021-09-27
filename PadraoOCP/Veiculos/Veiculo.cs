using System;

namespace PadraoOCP.Veiculos
{
    class Veiculo : IVeiculo
    {
        protected string Cor;
        protected int Ano;
        protected double Potencia;

        public Veiculo(string cor, int ano, double potencia)
        {
            Cor = cor;
            Ano = ano;
            Potencia = potencia;
        }

        public void LigaVeiculo()
        {
            Console.WriteLine("Motor Ligado !!!!");
        }
    }
}
