using System;
using System.Collections.Generic;
using System.Text;

namespace Pagarme.DTO
{
    class ClienteDTO
    {
        public string Tipo => "individual";
        public string Pais { get; set; }
        public string Nome { get; set; }


    }
}
