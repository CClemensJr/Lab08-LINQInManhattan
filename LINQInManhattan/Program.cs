using System;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;
using LINQInManhattan.Classes;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQInManhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitManhattan();

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        static void VisitManhattan()
        {
            // Read JSON from File, can use the normal streamreader way to read in as a string
            string jsonText = File.ReadAllText("../../../../data.json");
            RootObject manhattan = JsonConvert.DeserializeObject<RootObject>(jsonText);

            // Output all of the neighborhoods in dataset
            var neighborhoods = from f in manhattan.features
                         select f.properties.neighborhood;

            foreach (var neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
            
            // Filter out all neighborhoods with no names
            //var query2 = from neighborhood in neighborhoods
            //             where neighborhood.Length > 0
            //             select neighborhood;

            // Remove duplicates


            // Rewrite queries and consolidate into one single query


            // Rewrite one of these questions using the opposing method (lambda instead of LINQ or vice versa)

        }
    }
}
