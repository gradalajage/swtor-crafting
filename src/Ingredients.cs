using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwtorCrafting
{
    public class Ingredients : IIngredients
    {
        private Dictionary<Item, Ingredient> ingredients;

        public Ingredients()
        {
            this.ingredients = new Dictionary<Item, Ingredient>();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            if (this.ingredients.ContainsKey(ingredient.Item))
            {
                this.ingredients[ingredient.Item].Quantity += ingredient.Quantity;
                return;
            }

            this.ingredients.Add(ingredient.Item, ingredient);
        }

        public IEnumerable<Ingredient> GetIngredients()
        {
            return this.ingredients.Values;
        }

        public Ingredient GetIngredient(string itemName)
        {
            var item = new Item(itemName);
            if (this.ingredients.ContainsKey(item))
            {
                return this.ingredients[item];
            }

            throw new KeyNotFoundException();
        }

        public void AddIngredients(IIngredients ingredients)
        {
            foreach (var ingredient in ingredients.GetIngredients())
            {
                this.AddIngredient(ingredient);
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            foreach (var ingredient in this.GetIngredients())
            {
                stringBuilder.AppendLine($"{ingredient.Item.Name}: {ingredient.Quantity}");
            }

            return stringBuilder.ToString();
        }

        public int Count()
        {
            return this.ingredients.Count;
        }

        public int GetTotalCost()
        {
            return this.GetIngredients().Sum(i => i.Cost);
        }

        public static int GetTotalCostOfIngredients(IIngredients ingredients)
        {
            var totalCost = 0;
            foreach (var ingredient in ingredients.GetIngredients())
            {
                if (ingredient.Item.IsCraftable)
                {
                    continue;
                }

                totalCost += GetCostOfIngredient(ingredient);
            }

            return totalCost;
        }

        public static int GetCostOfIngredient(Ingredient ingredient)
        {
            return ingredient.Item.Cost * ingredient.Quantity;
        }
    }
}