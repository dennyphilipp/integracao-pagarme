using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pagarme.DTO
{
    class CartaoDTO : TransacaoDTO
    {
        [JsonProperty("amount")]
        public int Valor { get; set; }

        [JsonProperty("payment_method")]
        public string Tipo => "credit_card";

        [JsonProperty("customer")]
        public ClienteDTO Cliente { get; set; }

        [JsonProperty("card_number")]
        public string Numero { get; set; }

        [JsonProperty("card_cvv")]
        public string CVV { get; set; }

        [JsonProperty("card_expiration_date")]
        public string DataVencimento { get; set; }

        [JsonProperty("card_holder_name")]
        public string Nome { get; set; }

        [JsonProperty("installments")]
        public int Parcela { get; set; }

        [JsonProperty("billing")]
        public FaturamentoDTO Faturamento { get; set; }

        [JsonProperty("items")]
        public IEnumerable<ItemDTO> Itens { get; set; }

        [JsonProperty("capture")]
        public string Captura { get; set; }

        [JsonProperty("card_hash")]
        public string CardHash { get; set; }
    }
}
