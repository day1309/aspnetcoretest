using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SenegociaTest.Entities
{
    public class Indicator
    {
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "autor")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "codigo")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "nombre")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "unidad_medida")]
        public string Unit { get; set; }

        [JsonProperty(PropertyName = "serie")]
        public List<Serie> Series { get; set; }
    }

    public class Serie
    {
        [JsonProperty(PropertyName = "valor")]
        public double Value { get; set; }

        [JsonProperty(PropertyName = "fecha")]
        public DateTime Date { get; set; }
    }
}
