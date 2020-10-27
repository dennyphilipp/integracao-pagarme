using System;
using System.Collections.Generic;
using System.Text;

namespace Pagarme.Modelo
{
    class Cartao
    {
        public string Numero { get; set; }
        public string CVV { get; set; }
        public string Nome { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public string DataVencimento => $"{Mes}{Ano}".PadLeft(4, '0');
        public int Parcela { get; set; }
    }
}
