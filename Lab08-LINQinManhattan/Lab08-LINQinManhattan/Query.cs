using Lab08_LINQinManhattan.Classes;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace LAB08_LINQinManhatten
{
    class Query
    {
        // set path to access json data 
        string DATA_FILE_PATH = "../../../../manhattan.json";

        /// <summary>
        /// get data by reading file and deserialize the data
        /// </summary>
        /// <returns></returns>
        public Manhattan JsonConversionGetData()
        {
            string text = "";

            using (StreamReader sr = File.OpenText(DATA_FILE_PATH))
            {
                text = sr.ReadToEnd();
            }

            Manhattan data = JsonConvert.DeserializeObject<Manhattan>(text);
            return data;
        }

        /// <summary>
        /// get all manhattan neighborhoods in features class by selecting properties then accessing neighborhoods from there 
        /// </summary>
        /// <param name="manhattan"></param>
        public void GetNeighborhoods(Manhattan manhattan)
        {
            var neighborhoods = manhattan.Features.Select(x => x.Properties).Select(x => x.Neighborhood);
            foreach (string neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
        }

        /// <summary>
        /// filter all neighborhoods that do not have any names 
        /// </summary>
        /// <param name="manhattan"></param>
        public void FilterNeighborhoods(Manhattan manhattan)
        {
            var neighborhoods = manhattan.Features.Select(x => x.Properties).Select(x => x.Neighborhood).Where(x => x != "");
            foreach (string neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
        }

        /// <summary>
        /// remove any duplicates  
        /// </summary>
        /// <param name="manhattan"></param>
        public void RemoveDuplicates(Manhattan manhattan)
        {
            var neighborhoods = manhattan.Features.Select(x => x.Properties).Select(x => x.Neighborhood).Distinct();

            foreach (var neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
        }

        /// <summary>
        /// remove duplicates of neighborhoods without names
        /// </summary>
        /// <param name="manhattan"></param>
        public void RemoveDuplicateOfNeighborhoodWithoutNames(Manhattan manhattan)
        {
            var neighborhoods = manhattan.Features.Select(x => x.Properties).Select(x => x.Neighborhood).Where(x => x != "").Distinct();

            foreach (var neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
        }

        /// <summary>
        /// rewrite method to remove duplicates with LINQ
        /// </summary>
        /// <param name="manhattan"></param>
        public void ChangeToLINQ(Manhattan manhattan)
        {
            var neighborhoods = (from features in manhattan.Features
                                 where features.Properties.Neighborhood != ""
                                 select features.Properties.Neighborhood).Distinct();

            foreach (var neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
        }
    }
}