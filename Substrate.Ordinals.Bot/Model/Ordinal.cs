using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Substrate.Ordinals.Bot.Model
{
    public class OrdinalCreate
    {
        [JsonPropertyName("p")]
        public string Protocol { get; set; }

        [JsonPropertyName("op")]
        public string Operation { get; set; }

        [JsonPropertyName("tick")]
        public string Ticker { get; set; }

        [JsonPropertyName("max")]
        public string Maximum { get; set; }

        [JsonPropertyName("lim")]
        public string Limit { get; set; }
    }

    public class OrdinalMint
    {
        [JsonPropertyName("p")]
        public string Protocol { get; set; }

        [JsonPropertyName("op")]
        public string Operation { get; set; }

        [JsonPropertyName("tick")]
        public string Ticker { get; set; }

        [JsonPropertyName("amt")]
        public string Amount { get; set; }
    }

    public class OrdinalSingleMint
    {
        [JsonPropertyName("p")]
        public string Protocol { get; set; }

        [JsonPropertyName("op")]
        public string Operation { get; set; }

        [JsonPropertyName("tick")]
        public string Ticker { get; set; }
    }
}
