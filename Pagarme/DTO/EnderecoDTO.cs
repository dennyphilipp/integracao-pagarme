using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pagarme.DTO
{
    class EnderecoDTO
    {
        [JsonProperty("country")]
        public string Pais { get; set; }

        [JsonProperty("state")]
        public string Estado { get; set; }

        [JsonProperty("city")]
        public string Cidade { get; set; }

        [JsonProperty("zipcode")]
        public string CEP { get; set; }

        [JsonProperty("street_number")]
        public string Numero { get; set; }

        [JsonProperty("street")]
        public string Logradouro { get; set; }

        [JsonProperty("neighborhood")]
        public string Proximidade { get; set; }
    }
}
