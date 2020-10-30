using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pagarme.Modelo
{
    class Constante
    {
        public const string Chave = "ak_test_5Dqy14RUaChp63GxCrRZ8ZM5Sdwb6C";
        public const string UrlBase = "https://api.pagar.me/";
        public const string Transacao = "1/transactions";
        public const string QueryStatus = "?status={0}&api_key={1}&count=1000&page=1";
        public const string QueryId = "?id={0}&api_key={1}&count=1000&page=1";
        public static JsonSerializerSettings ConfiguracaoSerializacao = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore };
    }
}
