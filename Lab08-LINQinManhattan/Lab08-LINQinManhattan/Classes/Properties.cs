using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08_LINQinManhattan.Classes
{
    class Properties
    {
        [JsonProperty("Neighborhood")]
        public string Neighborhood { get; set; }
    }
}
