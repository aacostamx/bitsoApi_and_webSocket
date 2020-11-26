﻿using System;
using Newtonsoft.Json;

namespace WebSocket.DataModels
{
    public class OpenOrder
    {
        [JsonProperty("original_value")]
        public string OriginalValue { get; set; }

        [JsonProperty("unfilled_amount")]
        public string UnfilledAmount { get; set; }

        [JsonProperty("original_amount")]
        public string OriginalAmount { get; set; }

        [JsonProperty("book")]
        public string Book { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("oid")]
        public string Oid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }


        public decimal OriginalValueAsDecimal { get { return Convert.ToDecimal(OriginalValue); } }
        public decimal UnfilledAmountAsDecimal { get { return Convert.ToDecimal(UnfilledAmount); } }
        public decimal OriginalAmountAsDecimal { get { return Convert.ToDecimal(OriginalAmount); } }
        public decimal PriceAsDecimal { get { return Convert.ToDecimal(Price); } }
    }
}
