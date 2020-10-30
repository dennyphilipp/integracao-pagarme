using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pagarme.DTO
{
    class BaseDTO
    {
        [JsonProperty("api_key")]
        public string ChaveApi { get; set; }
    }
}
