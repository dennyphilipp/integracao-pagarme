using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pagarme.DTO
{
    class TransacaoDTO : BaseDTO
    {
        [JsonProperty("amount")]
        public int Valor { get; set; }

        [JsonProperty("customer")]
        public ClienteDTO Cliente { get; set; }
    }
}
