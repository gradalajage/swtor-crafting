using System.Collections.Generic;

namespace SwtorCrafting
{
    public interface IIngredients
    {
        public IEnumerable<Ingredient> GetIngredients();
        public void AddIngredient(Ingredient ingredient);
        public void AddIngredients(IIngredients ingredients);
        public string ToString();
    }
}