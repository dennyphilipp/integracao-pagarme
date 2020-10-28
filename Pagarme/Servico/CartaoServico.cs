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
    class CartaoServico
    {
        internal void Novo(Pessoa pessoa, Cartao cartao, decimal valor)
        {
            var cartaoDto = new CartaoDTO();
            cartaoDto.ChaveApi = Constante.Chave;
            cartaoDto.Parcela = cartao.Parcela;
            cartaoDto.CVV = cartao.CVV;
            cartaoDto.DataVencimento = cartao.DataVencimento;
            cartaoDto.Nome = cartao.Nome;
            cartaoDto.Numero = cartao.Numero;
            cartaoDto.Valor = (int)valor;
            cartaoDto.Cliente = new ClienteDTO();
            cartaoDto.Cliente.Nome = pessoa.Nome;
            cartaoDto.Cliente.Pais = "br";
            cartaoDto.Cliente.Id = Guid.NewGuid().ToString();
            cartaoDto.Cliente.Email = "nome@email.com.br";
            cartaoDto.Cliente.Telefones = new List<string> { "+5547988441122" };
            cartaoDto.Cliente.Nascimento = DateTime.Now.AddDays(-28).ToString("yyyy-MM-dd");
            cartaoDto.Cliente.Documentos = new List<DocumentoDTO> { new DocumentoDTO { Numero = pessoa.Documento, Tipo = "cpf" } };
            cartaoDto.Faturamento = new FaturamentoDTO { Nome = "Nome Completo", Endereco = new EnderecoDTO { CEP = "06714360", Cidade = "Cotia", Estado = "sp", Logradouro = "Rua", Numero = "99", Pais = "br" } };
            cartaoDto.Itens = new List<ItemDTO> { new ItemDTO { Fisico = true, Id = "12", Nome = "Folha", Quantidade = 1, Valor = 200 } };


            using (var requisicao = new HttpClient())
            {
                var configuracao = new JsonSerializerSettings();
                configuracao.NullValueHandling = NullValueHandling.Ignore;
                configuracao.DefaultValueHandling = DefaultValueHandling.Ignore;

                requisicao.BaseAddress = new Uri(Constante.UrlBase);
                var conteudo = new StringContent(JsonConvert.SerializeObject(cartaoDto, configuracao), Encoding.UTF8, MediaTypeNames.Application.Json);
                var resultado = requisicao.PostAsync(Constante.Transacao, conteudo).Result;
                if (!resultado.IsSuccessStatusCode)
                {
                    var erro = JsonConvert.DeserializeObject<RetornoErroDTO>(resultado.Content.ReadAsStringAsync().Result);
                    throw new Exception(erro.MensagemFormatada());
                }
                //return JsonConvert.DeserializeObject<BoletoRetornoDTO>(resultado.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
