using System.Collections.Generic;

namespace SwtorCrafting
{
    public class Recipe
    {
        public Recipe()
        {

        }

        public Recipe(string name)
        {
            this.Name = name;
        }

        public Recipe(string name, IEnumerable<Ingredient> ingredients)
        {
            this.Name = name;
            this.Ingredients = new Ingredients();
            foreach (var ingredient in ingredients)
            {
                this.Ingredients.AddIngredient(ingredient);
            }
        }
        
        public Recipe(string name, Ingredients ingredients)
        {
            this.Name = name;
            this.Ingredients = ingredients;
        }

        public Ingredients Ingredients { get; set; }

        public string Name { get; set; }
    }
}