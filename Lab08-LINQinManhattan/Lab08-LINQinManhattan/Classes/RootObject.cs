using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08_LINQinManhattan.Classes
{
    class RootObject
    {
        [JsonProperty("Type")]
        public string type { get; set; }

        [JsonProperty("Features")]
        public List<Feature> features { get; set; }
    }
}
