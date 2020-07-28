using System.Linq;
using Xunit;

namespace SwtorCrafting
{
    public class CraftingTableTests
    {
        [Fact]
        public void ingredientsToCraftStandardRecombinatorx1()
        {
            var ingredient = CraftingTable.GetIngredientsToLearnSchematicsAndCraftItem("Standard Recombinator", 1);
            Assert.Null(ingredient);
        }

        [Fact]
        public void ingredientsToCraftPremiumCuriousCellGraftx1()
        {
            var ingredient = CraftingTable.GetIngredientsToLearnSchematicsAndCraftItem("Premium Curious Cell Graft", 1);
            var ingredients = ingredient.Collate();
            Assert.Equal(21, ingredients.GetIngredients().Select(i => i.Quantity).Sum());
            Assert.Equal(1, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Curious Cell Graft").Quantity);
            Assert.Equal(8, ingredients.GetIngredients().Single(i => i.Item.Name == "Standard Recombinator").Quantity);
            Assert.Equal(6, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Unknown Microorganism").Quantity);
            Assert.Equal(6, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Virulent Extract").Quantity);
        }
        [Fact]
        public void ingredientsToCraftPrototypeKyrpraxMedpacx1()
        {
            var ingredient = CraftingTable.GetIngredientsToLearnSchematicsAndCraftItem("Prototype Kyrprax Medpac", 6);
            var ingredients = ingredient.Collate();
            Assert.Equal(706, ingredients.GetIngredients().Select(i => i.Quantity).Sum());
            Assert.Equal(66, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Kyrprax Medpac").Quantity);
            Assert.Equal(24, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Curious Cell Graft").Quantity);
            Assert.Equal(192, ingredients.GetIngredients().Single(i => i.Item.Name == "Standard Recombinator").Quantity);
            Assert.Equal(144, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Virulent Extract").Quantity);
            Assert.Equal(144, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Unknown Microorganism").Quantity);
            Assert.Equal(120, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Intravenous Injector").Quantity);
            Assert.Equal(6, ingredients.GetIngredients().Single(i => i.Item.Name == "Prototype Kyrprax Medpac").Quantity);
            Assert.Equal(10, ingredients.GetIngredients().Single(i => i.Item.Name == "Prototype Intravenous Injector").Quantity);
        }
        [Fact]
        public void ingredientsToCraftPremiumKyrpraxMedpacx11()
        {
            var ingredient = CraftingTable.GetIngredientsToLearnSchematicsAndCraftItem("Premium Kyrprax Medpac", 66);
            var ingredients = ingredient.Collate();
            Assert.Equal(638, ingredients.GetIngredients().Select(i => i.Quantity).Sum());
            Assert.Equal(66, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Kyrprax Medpac").Quantity);
            Assert.Equal(22, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Curious Cell Graft").Quantity);
            Assert.Equal(176, ingredients.GetIngredients().Single(i => i.Item.Name == "Standard Recombinator").Quantity);
            Assert.Equal(132, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Virulent Extract").Quantity);
            Assert.Equal(132, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Unknown Microorganism").Quantity);
            Assert.Equal(110, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Intravenous Injector").Quantity);
        }
    }
}