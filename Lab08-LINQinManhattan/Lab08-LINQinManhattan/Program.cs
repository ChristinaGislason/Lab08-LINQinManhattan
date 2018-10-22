using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lab08_LINQinManhattan.Classes;
using Newtonsoft.Json;

namespace Lab08_LINQinManhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            JsonConversion();
        }

        static void JsonConversion()
        {
            string path = "../../../data.json";
            string text = "";

            // using streamreader to access json file
            using (StreamReader sr = File.OpenText(path))
            {
                // get all the text
                text = sr.ReadToEnd();
            }

            // deserialize the JSON to convert to the Neighborhoods object
            List<Neighborhoods> myNeighborhoods = JsonConvert.DeserializeObject<List<Neighborhoods>>(text);

            // query to get all neighborhoods in manhattan  
            var neighborhoodNames = myNeighborhoods.Where(name => name.Neighborhood == "Neighborhood");

            foreach (var item in neighborhoodNames)
            {
                if (item.Neighborhood == "Neighborhood")
                {
                    Console.WriteLine(item.Neighborhood);
                }
            }
        }
    }
}
