using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioDaSegregacaoDeInterface.Veiculos
{
    class Carro : IVeiculoCarro 
        //, IVeiculos
    {
        private string Cor;
        private int Ano;
        private double Potencia;
        private int Bancos;
        private int Portas;

        public Carro(string cor, int ano, double potencia, int bancos, int portas)
        {
            ConfigureCar(cor, ano, potencia,bancos,portas);
        }

        public void ConfigureCar(string cor, int ano, double potencia, int bancos, int portas)
        {
            Cor = cor;
            Ano = ano;
            Potencia = potencia;
            Bancos = bancos;
            Portas = portas;
            Console.WriteLine($"Criando carro Cor: {Cor}, Ano: {Ano}, Potencia: {Potencia}, Qnt Bancos: {Bancos}, Qnt Portas: {Portas}");
            StartVeiculo();
        }


        public void StartVeiculo()
        {
            Console.WriteLine("Veiculo Ligado !!!!");
        }
    }
}
