using System;
using System.Collections.Generic;
using System.Text;

namespace Pagarme.Modelo
{
    class Consulta
    {
        public long Id { get; set; }
        public StatusPagamento Status { get; set; }
        public string Mensagem { get; set; }
    }
}
