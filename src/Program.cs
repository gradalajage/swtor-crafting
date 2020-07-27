using System;

namespace SwtorCrafting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var itemToCraft = "Advanced Kyrprax Medpac MK-2";
            var quantityToCraft = 1;
            var ingredient = CraftingTable.GetIngredientsToLearnSchematicsAndCraftItem(itemToCraft, quantityToCraft);
            Console.WriteLine(ingredient.Collate().ToString());

            Console.WriteLine("---");
            Console.WriteLine(ingredient.ToString());

            Console.WriteLine($"Total cost of ingredients: {ingredient.Cost}");
            Console.WriteLine($"Cost of purchasing item on GTN: {CraftingTable.GetItem(itemToCraft).GtnCost * quantityToCraft}");
        }
    }
}
