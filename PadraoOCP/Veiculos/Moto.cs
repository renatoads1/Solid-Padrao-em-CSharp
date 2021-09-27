using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoOCP.Veiculos
{
    class Moto : Veiculo
    {

        private int Cilindradas;
        private string Modelo;

        public Moto(string cor, int ano, double potencia,int cilindradas, string modelo):base(cor, ano, potencia) {

            Cilindradas = cilindradas;
            Modelo = modelo;
            ConfigureMoto();
        }

        public void ConfigureMoto() {
            Console.WriteLine("Criado uma Moto com " +
               $"\n cor: " + Cor +
               $"\n de Ano: " + Ano +
               $"\n de potencia: " + Potencia +
               $"\n de Acentos: " + Cilindradas +
               $"\n de Portas: " + Modelo + "");
            LigaVeiculo();

        }

    }
}
