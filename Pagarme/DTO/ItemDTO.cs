using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pagarme.DTO
{
    class ItemDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Nome { get; set; }

        [JsonProperty("unit_price")]
        public int Valor { get; set; }

        [JsonProperty("quantity")]
        public int Quantidade { get; set; }

        [JsonProperty("tangible")]
        public bool Fisico { get; set; }
    }
}
