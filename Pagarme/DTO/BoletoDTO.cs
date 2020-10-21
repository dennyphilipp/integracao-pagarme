using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Pagarme.DTO
{
    class BoletoDTO
    {
        public int Valor { get; set; }
        public string ChaveApi { get; set; }
        public string Tipo => "boleto";

    }
}
