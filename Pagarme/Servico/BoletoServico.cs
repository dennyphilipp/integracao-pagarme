using Newtonsoft.Json;
using Pagarme.DTO;
using Pagarme.Modelo;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Mime;
using System.Text;

namespace Pagarme.Servico
{
    class BoletoServico
    {
        internal BoletoRetornoDTO Novo(Pessoa pessoa)
        {
            var boletoDto = new BoletoDTO();
            boletoDto.ChaveApi = Constante.Chave;
            boletoDto.Valor = 5000;
            boletoDto.Cliente = new ClienteDTO();
            boletoDto.Cliente.Nome = pessoa.Nome;
            boletoDto.Cliente.Pais = "br";
            boletoDto.Cliente.Documentos = new List<DocumentoDTO> { new DocumentoDTO {Numero = pessoa.Documento, Tipo = "cpf" } };

            using (var requisicao = new HttpClient())
            {
                requisicao.BaseAddress = new Uri(Constante.UrlBase);
                var conteudo = new StringContent(JsonConvert.SerializeObject(boletoDto), Encoding.UTF8, MediaTypeNames.Application.Json);
                var resultado = requisicao.PostAsync(Constante.NovoBoleto, conteudo).Result;
                if (!resultado.IsSuccessStatusCode)
                {
                    var erro = JsonConvert.DeserializeObject<RetornoErroDTO>(resultado.Content.ReadAsStringAsync().Result);
                    throw new Exception(erro.MensagemFormatada());
                }
                return JsonConvert.DeserializeObject<BoletoRetornoDTO>(resultado.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
