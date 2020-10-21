using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Pagarme.DTO
{
    class BoletoDTO
    {
        [JsonProperty("amount")]
        public int Valor { get; set; }

        [JsonProperty("api_key")]
        public string ChaveApi { get; set; }

        [JsonProperty("payment_method")]
        public string Tipo => "boleto";

        [JsonProperty("customer")]
        public ClienteDTO Cliente { get; set; }
    }
}
