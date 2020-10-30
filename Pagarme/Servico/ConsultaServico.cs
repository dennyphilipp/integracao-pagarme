using Newtonsoft.Json;
using Pagarme.DTO;
using Pagarme.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Pagarme.Servico
{
    class ConsultaServico
    {

        internal List<TransacaoRetornoDTO> Obter(List<long> ids)
        {
            var lista = new List<TransacaoRetornoDTO>();
            foreach (var item in ids)
            {
                var url = string.Format(Constante.QueryId, item, Constante.Chave);
                var consulta = Consultar(url);
                lista.Add(consulta.FirstOrDefault());
            }
            return lista;
        }

        internal List<TransacaoRetornoDTO> Obter(StatusPagamento status)
        {
            var url = string.Format(Constante.QueryStatus, ParaStatus(status), Constante.Chave);
            return Consultar(url);
            
        }

        private List<TransacaoRetornoDTO> Consultar(string url)
        {
            using (var requisicao = new HttpClient())
            {
                requisicao.BaseAddress = new Uri(Constante.UrlBase);
                var resultado = requisicao.GetAsync($"{Constante.Transacao}{url}").Result;
                if (!resultado.IsSuccessStatusCode)
                {
                    var erro = JsonConvert.DeserializeObject<RetornoErroDTO>(resultado.Content.ReadAsStringAsync().Result);
                    throw new Exception(erro.MensagemFormatada());
                }
                return JsonConvert.DeserializeObject<List<TransacaoRetornoDTO>>(resultado.Content.ReadAsStringAsync().Result);
            }
        }

        private string ParaStatus(StatusPagamento status)
        {
            switch (status)
            {
                case StatusPagamento.Aguardando:
                    return "waiting_payment";
                case StatusPagamento.Recusado:
                    return "refused";
                case StatusPagamento.Autorizado:
                    return "authorized";
                case StatusPagamento.Pago:
                    return "paid";
                case StatusPagamento.Processando:
                    return "processing";
                case StatusPagamento.Estornado:
                    return "refunded";
                case StatusPagamento.AguardandoEstorno:
                    return "pending_refund";
                case StatusPagamento.Analise:
                    return "analyzing";
                case StatusPagamento.Pendente:
                    return "pending_review";
                default:
                    return string.Empty;
            }
        }
    }
}
