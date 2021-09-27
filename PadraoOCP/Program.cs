using PadraoOCP.Veiculos;
using System;

namespace PadraoOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            TipoVeiculo type = TipoVeiculo.MOTO;
            if (type == TipoVeiculo.CARRO)
            {
                Carro veiculo = new Carro(5,5,"preta",2011,4.5);
                veiculo.ConfigureCarro();
            }
            else {
                Moto veiculo = new Moto("Vermelha", 2008,450,1000,"honda");
                veiculo.ConfigureMoto();
            }
            Console.ReadKey();
        }
    }
}
