using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08_LINQinManhattan.Classes
{
    class Feature
    {
        [JsonProperty("Type")]
        public string type { get; set; }

        [JsonProperty("Properties")]
        public Properties properties { get; set; }
    }
}


