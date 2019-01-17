using System;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;

namespace LINQInManhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitManhattan();
        }

        static void VisitManhattan()
        {
            // Read JSON from File, can use the normal streamreader way to read in as a string
            using (StreamReader reader = File.OpenText("data.json"))
            {
                JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
            }

            
            // Output all of the neighborhoods in dataset
            // Filter out all neighborhoods with no names
            // Remove duplicates
            // Rewrite queries and consolidate into one single query
            // Rewrite one of these questions using the opposing method (lambda instead of LINQ or vice versa)

        }
    }
}
