using System;

namespace PadraoOCP.Veiculos
{
    class Carro : Veiculo
    {
        private int Acentos;
        private int Portas;

        public Carro(int acentos, int portas, string cor, int ano, double potencia): base(cor,ano,potencia)
        {
            Acentos = acentos;
            Portas = portas;
            ConfigureCarro();
        }
        public void ConfigureCarro()
        {
            Console.WriteLine("Criado um carro com " +
                $"\n cor: " + Cor +
                $"\n de Ano: " + Ano +
                $"\n de potencia: " + Potencia +
                $"\n de Acentos: " + Acentos +
                $"\n de Portas: " + Portas + "");

            LigaVeiculo();
        }
    }
}
