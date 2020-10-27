using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pagarme.DTO
{
    class FaturamentoDTO
    {
        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("address")]
        public EnderecoDTO Endereco { get; set; }

    }
}
