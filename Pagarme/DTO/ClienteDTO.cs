using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pagarme.DTO
{
    class ClienteDTO
    {
        [JsonProperty("external_id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Tipo => "individual";

        [JsonProperty("country")]
        public string Pais { get; set; }

        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("documents")]
        public List<DocumentoDTO> Documentos { get; set; }

        [JsonProperty("phone_numbers")]
        public IEnumerable<string> Telefones { get; set; }

        [JsonProperty("birthday")]
        public string Nascimento { get; set; }
    }
}
