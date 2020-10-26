using Pagarme.Servico;
using System;

namespace Pagarme
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new BoletoServico();
            b.Novo(new Modelo.Pessoa { Documento = "00000000000", Nome = "Nome Completo", Telefone = "47988776655" });
            Console.ReadLine();
        }
        
    }
}
