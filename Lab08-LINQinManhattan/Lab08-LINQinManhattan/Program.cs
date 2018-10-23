using Lab08_LINQinManhattan.Classes;
using System;

namespace LAB08_LINQinManhatten
{
    class Program
    {
        static void Main(string[] args)
        {
            // output all neighborhoods in data
            Query query = new Query();
            Manhattan manhattan = query.JsonConversionGetData();
            Console.WriteLine("----------");
            Console.WriteLine("Output all neighborhoods in data list");
            query.GetNeighborhoods(manhattan);

            // filter out neighborhoods that do not have names
            Console.WriteLine("----------");
            Console.WriteLine("Filter out all neighborhoods that do not have names");
            query.FilterNeighborhoods(manhattan);

            // remove duplicates
            Console.WriteLine("----------");
            Console.WriteLine("Remove duplicates");
            query.RemoveDuplicates(manhattan);

            // filter out neighborhoods that do not have names
            Console.WriteLine("----------");
            Console.WriteLine("Remove duplicates");
            Console.WriteLine("Filter out all neighborhoods that do not have names");
            query.RemoveDuplicateOfNeighborhoodWithoutNames(manhattan);

            // run method that was rewritten to remove duplicates using LINQ
            Console.WriteLine("----------");
            Console.WriteLine("Using LINQ");
            query.ChangeToLINQ(manhattan);
        }
    }
}