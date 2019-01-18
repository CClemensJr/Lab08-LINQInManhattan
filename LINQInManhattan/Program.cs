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

            JObject json = JObject.Parse(jsonText);

            IList<JToken> results = json["type"]["features"].Children().ToList();

            IList<RootObject> searchResults = new List<RootObject>();
            foreach (JToken result in results)
            {
                RootObject root = result.ToObject<RootObject>();
                root.Add(root);
            }


            //RootObject root = JsonConvert.DeserializeObject<RootObject>(json);

            //foreach (var feature in root.features)
            //{
            //    Console.WriteLine(feature);
            //}
            // Output all of the neighborhoods in dataset
            // Filter out all neighborhoods with no names
            // Remove duplicates
            // Rewrite queries and consolidate into one single query
            // Rewrite one of these questions using the opposing method (lambda instead of LINQ or vice versa)

        }
    }
}
