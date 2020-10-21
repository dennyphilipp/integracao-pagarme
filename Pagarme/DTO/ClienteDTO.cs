using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pagarme.DTO
{
    class ClienteDTO
    {
        [JsonProperty("type")]
        public string Tipo => "individual";

        [JsonProperty("country")]
        public string Pais { get; set; }

        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("documents")]
        public List<DocumentoDTO> Documentos { get; set; }
    }
}
