using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioDaSegregacaoDeInterface.Veiculos
{
    interface IVeiculoMoto : IVeiculos
    {
        void ConfigureMoto(string cor, int ano, double potencia);
    }
}
