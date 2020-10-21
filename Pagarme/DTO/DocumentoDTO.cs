using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pagarme.DTO
{
    class DocumentoDTO
    {
        [JsonProperty("type")]
        public string Tipo { get; set; }

        [JsonProperty("number")]
        public string Numero { get; set; }
    }
}
