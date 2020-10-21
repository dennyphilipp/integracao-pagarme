using Pagarme.Servico;
using System;

namespace Pagarme
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new BoletoServico();
            b.Novo(null, null);
            Console.ReadLine();
        }
        
    }
}
