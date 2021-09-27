using PrincipioDaSegregacaoDeInterface.Veiculos;
using System;

namespace PrincipioDaSegregacaoDeInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro("Verde",2021,1.8,4,5);
            Moto mot = new Moto("Verde",2021,1000);
            
            Console.ReadKey();
        }
    }
}
