using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency_converter.Classes
{
    public class Currencies
    {
        [JsonProperty("aud")]
        public double aud { get; set; }

        [JsonProperty("cad")]
        public double cad { get; set; }

        [JsonProperty("chf")]
        public double chf { get; set; }

        [JsonProperty("cny")]
        public double cny { get; set; }

        [JsonProperty("eur")]
        public double eur { get; set; }

        [JsonProperty("gbp")]
        public double gbp { get; set; }

        [JsonProperty("hkd")]
        public double hkd { get; set; }

        [JsonProperty("inr")]
        public double inr { get; set; }

        [JsonProperty("jpy")]
        public double jpy { get; set; }

        [JsonProperty("mxn")]
        public double mxn { get; set; }

        [JsonProperty("nzd")]
        public double nzd { get; set; }

        [JsonProperty("rub")]
        public double rub { get; set; }

        [JsonProperty("sek")]
        public double sek { get; set; }

        [JsonProperty("sgd")]
        public double sgd { get; set; }

        [JsonProperty("usd")]
        public double usd { get; set; }
    }

    public class Root
    {
        // using json property because different name of object compared to JSON name in website result
        [JsonProperty("date")]
        public string Date { get; set; }

        public Currencies Base { get; set; }

        //public Currencies aud_base { set { Base = value; } }
        [JsonProperty("aud")]
        private Currencies aud_base { set { Base = value; } }

        [JsonProperty("cad")]
        private Currencies cad_base { set { Base = value; } }

        [JsonProperty("chf")]
        private Currencies chf_base { set { Base = value; } }

        [JsonProperty("cny")]
        private Currencies cny_base { set { Base = value; } }

        [JsonProperty("eur")]
        private Currencies eur_base { set { Base = value; } }

        [JsonProperty("gbp")]
        private Currencies gbp_base { set { Base = value; } }

        [JsonProperty("hkd")]
        private Currencies hkd_base { set { Base = value; } }

        [JsonProperty("inr")]
        private Currencies inr_base { set { Base = value; } }

        [JsonProperty("jpy")]
        private Currencies jpy_base { set { Base = value; } }

        [JsonProperty("mxn")]
        private Currencies mxn_base { set { Base = value; } }

        [JsonProperty("nzd")]
        private Currencies nzd_base { set { Base = value; } }

        [JsonProperty("rub")]
        private Currencies rub_base { set { Base = value; } }

        [JsonProperty("sek")]
        private Currencies sek_base { set { Base = value; } }

        [JsonProperty("sgd")]
        private Currencies sgd_base { set { Base = value; } }

        [JsonProperty("usd")]
        private Currencies usd_base { set { Base = value; } }
    }
}
