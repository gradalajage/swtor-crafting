using System.Collections.Generic;

namespace SwtorCrafting
{
    public interface IIngredients
    {
        public IEnumerable<Ingredient> GetIngredients();
        public Ingredient GetIngredient(string itemName);
        public void AddIngredient(Ingredient ingredient);
        public void AddIngredients(IIngredients ingredients);
        public int Count();
        public int GetTotalCost();
    }
}