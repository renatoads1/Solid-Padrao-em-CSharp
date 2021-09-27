using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioDaSegregacaoDeInterface.Veiculos
{
    interface IVeiculoCarro : IVeiculos
    {
        void ConfigureCar(string cor, int ano, double potencia, int bancos, int portas);
    }
}
