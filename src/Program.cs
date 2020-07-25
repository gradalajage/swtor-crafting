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
            var ingredients = CraftingTable.GetRequiredIngredients("Advanced Kyrprax Medpac MK-2", 1);
            Console.WriteLine(ingredients.ToString());
        }
    }
}
