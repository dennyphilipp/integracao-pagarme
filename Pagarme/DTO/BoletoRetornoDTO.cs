using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pagarme.DTO
{
    class BoletoRetornoDTO
    {

        [JsonProperty("object")]
        public string Tipo { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("refuse_reason")]
        public object MotivoRecusado { get; set; }

        [JsonProperty("status_reason")]
        public string MotivoStatus { get; set; }

        [JsonProperty("acquirer_name")]
        public string Adquirente { get; set; }

        [JsonProperty("acquirer_id")]
        public string AdquirenteId { get; set; }

        [JsonProperty("authorization_code")]
        public object Autorizacao { get; set; }

        [JsonProperty("tid")]
        public int TId { get; set; }

        [JsonProperty("nsu")]
        public int NumeroSequencial { get; set; }

        [JsonProperty("date_created")]
        public DateTime DataCriacao { get; set; }

        [JsonProperty("date_updated")]
        public DateTime DataAlteracao { get; set; }

        [JsonProperty("amount")]
        public int Valor { get; set; }

        [JsonProperty("authorized_amount")]
        public int ValorAutorizado { get; set; }

        [JsonProperty("paid_amount")]
        public int ValorPago { get; set; }

        [JsonProperty("refunded_amount")]
        public int ValorReembolsado { get; set; }

        [JsonProperty("installments")]
        public int Parcelas { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("cost")]
        public int Custo { get; set; }
        
        [JsonProperty("postback_url")]
        public object UrlRetorno { get; set; }

        [JsonProperty("payment_method")]
        public string FormaPagamento { get; set; }

        [JsonProperty("capture_method")]
        public string capture_method { get; set; }

        [JsonProperty("boleto_url")]
        public string UrlBoleto { get; set; }

        [JsonProperty("boleto_barcode")]
        public string CodigoBarras { get; set; }

        [JsonProperty("boleto_expiration_date")]
        public DateTime DataVencimento { get; set; }

        [JsonProperty("referer")]
        public string Referencia { get; set; }

        [JsonProperty("fraud_covered")]
        public bool FraudeHabilitado { get; set; }
    }

}
