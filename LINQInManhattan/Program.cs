using System;
using System.IO;
using Newtonsoft.Json;
using LINQInManhattan.Classes;
using System.Linq;

namespace LINQInManhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitManhattan();

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadLine();
        }


        /// <summary>
        /// This method reads in the json data, populates the classes, and displays query results to the console.
        /// </summary>
        static void VisitManhattan()
        {
            // Read JSON from File, can use the normal streamreader way to read in as a string
            string jsonText = File.ReadAllText("../../../../data.json");
            RootObject manhattan = JsonConvert.DeserializeObject<RootObject>(jsonText);


            // Output all of the neighborhoods in dataset
            var query1 = from f in manhattan.features
                         select f.properties.neighborhood;

            foreach (var neighborhood in query1)
            {
                Console.WriteLine(neighborhood);
            }

            Console.WriteLine("\n\n ----------------------------------------------------------------------------------------------------\n\n");


           // Filter out all neighborhoods with no names
           var query2 = from neighborhood in query1
                        where neighborhood.Length > 0
                        select neighborhood;

            foreach (var neighborhood in query2)
            {
                Console.WriteLine(neighborhood);
            }

            Console.WriteLine("\n\n ----------------------------------------------------------------------------------------------------\n\n");


            // Remove duplicates
            var query3 = query2.Distinct();

            foreach (var neighborhood in query3)
            {
                Console.WriteLine(neighborhood);
            }

            Console.WriteLine("\n\n ----------------------------------------------------------------------------------------------------\n\n");


            // Rewrite queries and consolidate into one single query
            // Was unable to get neighborhood to appear correctly in console so I implemented the class solution
            var allQueries = manhattan.features.Where(n => n.properties.neighborhood.Length > 0)
                                               .GroupBy(g => g.properties.neighborhood)
                                               .Select(s => s.First());

            //allQueries = allQueries.Distinct();


            foreach (var neighborhood in allQueries)
            {
                Console.WriteLine(neighborhood.properties.neighborhood);
            }

            Console.WriteLine("\n\n ----------------------------------------------------------------------------------------------------\n\n");


            // Rewrite one of these questions using the opposing method (lambda instead of LINQ or vice versa)
            // Rewrote Query 1
            var newQuery1 = manhattan.features.Select(s => s.properties.neighborhood);
      
            foreach (var neighborhood in newQuery1)
            {
                Console.WriteLine(neighborhood);
            }

            Console.WriteLine("\n\n ----------------------------------------------------------------------------------------------------\n\n");
        }
    }
}
