using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Lab08_LINQinManhattan.Classes
{
    class Neighborhoods
    {
        [JsonProperty("Neighborhood")]
        public string Neighborhood { get; set; }
    }
}
