using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pagarme.DTO
{

    class RetornoErroDTO
    {
        [JsonProperty("errors")]
        public ErroDTO[] Erros { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("method")]
        public string MetodoHttp { get; set; }

    
        internal string MensagemFormatada()
        {
            if (Erros == null || Erros.Length <= 0)
                return string.Empty;

            var mensagens = Erros.Select(s => s.Mensagem).ToArray();

            return string.Join(", ", mensagens);
        }
    }
    class ErroDTO
    {
        [JsonProperty("type")]
        public string Tipo { get; set; }

        [JsonProperty("parameter_name")]
        public object NomeParametro { get; set; }

        [JsonProperty("message")]
        public string Mensagem { get; set; }
    }

}
