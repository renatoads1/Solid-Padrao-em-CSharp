using InverssaoDeDependencia.Factory;
using InverssaoDeDependencia.Model;
using InverssaoDeDependencia.Payments;
using System;

namespace InverssaoDeDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DbProduct payment = DbProductFactory.Create();
            string productData = payment.GetProductById("123456");
            Console.WriteLine(productData);
            Console.ReadKey();
        }
    }
}
