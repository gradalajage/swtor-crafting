using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace SwtorCrafting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var requiredItems = CraftingTable.ComputeRequiredItemsToCraft("Advanced Kyrprax Medpac MK-2", 1);

            //var query = requiredItems.GroupBy(item => item.Name);


            foreach (var line in requiredItems.GroupBy(i => i.Name)
                        .Select(group => new { 
                             Name = group.Key, 
                             Count = group.Count() 
                        })
                        .OrderBy(i => i.Name))
            {
                        Console.WriteLine("{0}: {1}", line.Name, line.Count);
            }
            // Console.WriteLine(
            //     JsonSerializer.Serialize(
            //         premiumCuriousCellGraft, 
            //         new JsonSerializerOptions{ 
            //             WriteIndented = true, 
            //             PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            //         }
            //     )
            // );
        }
    }
}
