using System.Linq;
using Xunit;

namespace SwtorCrafting
{
    public class CraftingTableTests
    {
        [Fact]
        public void RequiredItemsToCraftStandardRecombinatorx1()
        {
            var requiredItems = CraftingTable.ComputeRequiredItemsToCraft("Standard Recombinator", 1);
            Assert.Equal(0, requiredItems.ToList().Count);
        }

        [Fact]
        public void RequiredItemsToCraftPremiumCuriousCellGraftx1()
        {
            var requiredItems = CraftingTable.ComputeRequiredItemsToCraft("Premium Curious Cell Graft", 1);
            Assert.Equal(21, requiredItems.ToList().Count);
            Assert.Equal(1, requiredItems.Where(i => i.Name == "Premium Curious Cell Graft").Count());
            Assert.Equal(8, requiredItems.Where(i => i.Name == "Standard Recombinator").Count());
            Assert.Equal(6, requiredItems.Where(i => i.Name == "Premium Unknown Microorganism").Count());
            Assert.Equal(6, requiredItems.Where(i => i.Name == "Premium Virulent Extract").Count());
        }
        [Fact]
        public void RequiredItemsToCraftPrototypeKyrpraxMedpacx1()
        {
            var requiredItems = CraftingTable.ComputeRequiredItemsToCraft("Prototype Kyrprax Medpac", 1);
            Assert.Equal(646, requiredItems.ToList().Count);
            Assert.Equal(11, requiredItems.Where(i => i.Name == "Premium Kyrprax Medpac").Count());
            Assert.Equal(24, requiredItems.Where(i => i.Name == "Premium Curious Cell Graft").Count());
            Assert.Equal(192, requiredItems.Where(i => i.Name == "Standard Recombinator").Count());
            Assert.Equal(144, requiredItems.Where(i => i.Name == "Premium Virulent Extract").Count());
            Assert.Equal(144, requiredItems.Where(i => i.Name == "Premium Unknown Microorganism").Count());
            Assert.Equal(120, requiredItems.Where(i => i.Name == "Premium Intravenous Injector").Count());
            Assert.Equal(1, requiredItems.Where(i => i.Name == "Prototype Kyrprax Medpac").Count());
            Assert.Equal(10, requiredItems.Where(i => i.Name == "Prototype Intravenous Injector").Count());
        }
        [Fact]
        public void RequiredItemsToCraftPremiumKyrpraxMedpacx11()
        {
            var requiredItems = CraftingTable.ComputeRequiredItemsToCraft("Premium Kyrprax Medpac", 11);
            Assert.Equal(583, requiredItems.ToList().Count);
            Assert.Equal(11, requiredItems.Where(i => i.Name == "Premium Kyrprax Medpac").Count());
            Assert.Equal(22, requiredItems.Where(i => i.Name == "Premium Curious Cell Graft").Count());
            Assert.Equal(176, requiredItems.Where(i => i.Name == "Standard Recombinator").Count());
            Assert.Equal(132, requiredItems.Where(i => i.Name == "Premium Virulent Extract").Count());
            Assert.Equal(132, requiredItems.Where(i => i.Name == "Premium Unknown Microorganism").Count());
            Assert.Equal(110, requiredItems.Where(i => i.Name == "Premium Intravenous Injector").Count());
        }
    }
}