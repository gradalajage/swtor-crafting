using System.Collections.Generic;

namespace SwtorCrafting
{
    public class Recipe
    {
        public Recipe()
        {
        }

        public Recipe(Ingredient output)
        {
            this.Output = output;
        }

        public Recipe(IEnumerable<Ingredient> inputs, Ingredient output)
            : this(output)
        {
            this.Inputs = new Ingredients();
            foreach (var input in inputs)
            {
                this.Inputs.AddIngredient(input);
            }
        }
        
        public Recipe(Ingredients inputs, Ingredient output)
            : this(output)
        {
            this.Inputs = inputs;
        }

        public Ingredients Inputs { get; set; }

        public Ingredient Output { get; set; }
    }
}