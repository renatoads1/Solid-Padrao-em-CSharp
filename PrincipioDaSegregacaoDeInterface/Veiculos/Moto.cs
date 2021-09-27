using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioDaSegregacaoDeInterface.Veiculos
{
    class Moto : IVeiculoMoto 
        //, IVeiculos
    {
        private string Cor;
        private int Ano;
        private double Potencia;

        public Moto(string cor, int ano, double potencia)
        {
            ConfigureMoto(cor, ano, potencia);
        }

        public void ConfigureMoto(string cor, int ano, double potencia)
        {
            Cor = cor;
            Ano = ano;
            Potencia = potencia;
            Console.WriteLine($"Criando Moto Cor: {Cor}, Ano: {Ano}, Cilindradas: {Potencia}");
            StartVeiculo();
        }

        public void StartVeiculo()
        {
            Console.WriteLine("Veiculo Ligado !!!!");
        }
    }
}
