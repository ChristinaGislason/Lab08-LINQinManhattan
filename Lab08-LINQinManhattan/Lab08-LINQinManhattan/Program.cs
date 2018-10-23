using Lab08_LINQinManhattan.Classes;
using System;

namespace LAB08_LINQinManhatten
{
    class Program
    {
        static void Main(string[] args)
        {
            Query query = new Query();
            Manhattan manhattan = query.JsonConversionGetData();
            Console.WriteLine("----------");
            Console.WriteLine("Output all neighborhoods in data list");
            query.GetNeighborhoods(manhattan);

            Console.WriteLine("----------");
            Console.WriteLine("Filter out all neighborhoods that do not have names");
            query.FilterNeighborhoods(manhattan);

            Console.WriteLine("----------");
            Console.WriteLine("Remove duplicates");
            query.RemoveDuplicates(manhattan);

            Console.WriteLine("----------");
            Console.WriteLine("Remove duplicates");
            Console.WriteLine("Filter out all neighborhoods that do not have names");
            query.RemoveDuplicateOfNeighborhoodWithoutNames(manhattan);

            Console.WriteLine("----------");
            Console.WriteLine("Using LINQ");
            query.ChangeToLINQ(manhattan);
        }
    }
}