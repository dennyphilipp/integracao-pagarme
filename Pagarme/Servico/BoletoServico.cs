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
        internal void Novo(Pessoa pessoa, Endereco endereco)
        {
            var boletoDto = new BoletoDTO();
            boletoDto.ChaveApi = Constante.Chave;
            boletoDto.Valor = 5000;
            boletoDto.Cliente = new ClienteDTO();
            boletoDto.Cliente.Nome = "Nome Completo";
            boletoDto.Cliente.Pais = "Brasil";
            boletoDto.Cliente.Documentos = new List<DocumentoDTO> { new DocumentoDTO {Numero = "00000000000", Tipo = "cpf" } };

            using (var requisicao = new HttpClient())
            {
                requisicao.BaseAddress = new Uri(Constante.UrlBase);
                var json = new StringContent(JsonConvert.SerializeObject(boletoDto), Encoding.UTF8, MediaTypeNames.Application.Json);
                var resultado = requisicao.PostAsync(Constante.NovoBoleto, json).Result;
                if (resultado.IsSuccessStatusCode)
                {
                    var t = resultado.Content.ReadAsStringAsync().Result;
                }

            }
        }
    }
}
