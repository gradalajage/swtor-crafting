using System.Linq;
using Xunit;

namespace SwtorCrafting
{
    public class CraftingTableTests
    {
        [Fact]
        public void ingredientsToCraftStandardRecombinatorx1()
        {
            var ingredients = CraftingTable.GetRequiredIngredients("Standard Recombinator", 1);
            Assert.Equal(0, ingredients.GetIngredients().Select(i => i.Quantity).Sum());
        }

        [Fact]
        public void ingredientsToCraftPremiumCuriousCellGraftx1()
        {
            var ingredients = CraftingTable.GetRequiredIngredients("Premium Curious Cell Graft", 1);
            Assert.Equal(21, ingredients.GetIngredients().Select(i => i.Quantity).Sum());
            Assert.Equal(1, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Curious Cell Graft").Quantity);
            Assert.Equal(8, ingredients.GetIngredients().Single(i => i.Item.Name == "Standard Recombinator").Quantity);
            Assert.Equal(6, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Unknown Microorganism").Quantity);
            Assert.Equal(6, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Virulent Extract").Quantity);
        }
        [Fact]
        public void ingredientsToCraftPrototypeKyrpraxMedpacx1()
        {
            var ingredients = CraftingTable.GetRequiredIngredients("Prototype Kyrprax Medpac", 1);
            Assert.Equal(646, ingredients.GetIngredients().Select(i => i.Quantity).Sum());
            Assert.Equal(11, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Kyrprax Medpac").Quantity);
            Assert.Equal(24, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Curious Cell Graft").Quantity);
            Assert.Equal(192, ingredients.GetIngredients().Single(i => i.Item.Name == "Standard Recombinator").Quantity);
            Assert.Equal(144, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Virulent Extract").Quantity);
            Assert.Equal(144, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Unknown Microorganism").Quantity);
            Assert.Equal(120, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Intravenous Injector").Quantity);
            Assert.Equal(1, ingredients.GetIngredients().Single(i => i.Item.Name == "Prototype Kyrprax Medpac").Quantity);
            Assert.Equal(10, ingredients.GetIngredients().Single(i => i.Item.Name == "Prototype Intravenous Injector").Quantity);
        }
        [Fact]
        public void ingredientsToCraftPremiumKyrpraxMedpacx11()
        {
            var ingredients = CraftingTable.GetRequiredIngredients("Premium Kyrprax Medpac", 11);
            Assert.Equal(583, ingredients.GetIngredients().Select(i => i.Quantity).Sum());
            Assert.Equal(11, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Kyrprax Medpac").Quantity);
            Assert.Equal(22, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Curious Cell Graft").Quantity);
            Assert.Equal(176, ingredients.GetIngredients().Single(i => i.Item.Name == "Standard Recombinator").Quantity);
            Assert.Equal(132, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Virulent Extract").Quantity);
            Assert.Equal(132, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Unknown Microorganism").Quantity);
            Assert.Equal(110, ingredients.GetIngredients().Single(i => i.Item.Name == "Premium Intravenous Injector").Quantity);
        }
    }
}