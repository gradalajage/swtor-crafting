using System;
using System.Collections.Generic;

namespace SwtorCrafting
{
    public class CraftingTable
    {
        private static Item premiumCuriousCellGraft = new Item(
            "Premium Curious Cell Graft",
            new Schematic(
                null,
                new Recipe(
                    new Ingredient[] {
                        new Ingredient(new Item("Standard Recombinator"), 8),
                        new Ingredient(new Item("Premium Unknown Microorganism"), 6),
                        new Ingredient(new Item("Premium Virulent Extract"), 6),
                    },
                    new Ingredient(new Item("Premium Curious Cell Graft"), 1)
                )
            ),
            40000,
            null
        );

        private static Item premiumKyrpraxMedpac = new Item(
            "Premium Kyrprax Medpac",
            0.2f,
            new Schematic("Prototype Kyrprax Medpac"),
            new Schematic(
                null,
                new Recipe(
                    new Ingredient[] {
                        new Ingredient(new Item("Premium Curious Cell Graft"), 2),
                        new Ingredient(new Item("Premium Intravenous Injector"), 10),
                    },
                    new Ingredient(new Item("Premium Kyrprax Medpac"), 6)
                )
            ),
            5000,
            null
        );

        private static Item prototypeKyrpraxMedpac = new Item(
            "Prototype Kyrprax Medpac",
            0.2f,
            new Schematic("Advanced Kyrprax Medpac"),
            new Schematic(
                new Item("Premium Kyrprax Medpac"),
                new Recipe(
                    new Ingredient[] {
                        new Ingredient(new Item("Premium Curious Cell Graft"), 2),
                        new Ingredient(new Item("Premium Intravenous Injector"), 10),
                        new Ingredient(new Item("Prototype Intravenous Injector"), 10),
                    },
                    new Ingredient(new Item("Prototype Kyrprax Medpac"), 6)
                )
            ),
            18888,
            null
        );

        private static Item prototypeCuriousCellGraft = new Item(
            "Prototype Curious Cell Graft",
            new Schematic(
                null,
                new Recipe(
                    new Ingredient[] {
                        new Ingredient(new Item("Premium Recombinator"), 8),
                        new Ingredient(new Item("Prototype Unknown Microorganism"), 6),
                        new Ingredient(new Item("Prototype Virulent Extract"), 6),
                        new Ingredient(new Item("Premium Curious Cell Graft"), 2),
                    },
                    new Ingredient(new Item("Prototype Curious Cell Graft"), 1)
                )
            ),
            60000,
            null
        );

        private static Item artifactCuriousCellGraft = new Item(
            "Artifact Curious Cell Graft",
            new Schematic(
                null,
                new Recipe(
                    new Ingredient[] {
                        new Ingredient(new Item("Prototype Recombinator"), 12),
                        new Ingredient(new Item("Artifact Unknown Microorganism"), 12),
                        new Ingredient(new Item("Artifact Virulent Extract"), 12),
                        new Ingredient(new Item("Prototype Curious Cell Graft"), 3),
                    },
                    new Ingredient(new Item("Artifact Curious Cell Graft"), 1)
                )
            ),
            354950,
            null
        );

        private static Item advancedKyrpraxMedpac = new Item(
            "Advanced Kyrprax Medpac",
            0.05f,
            new Schematic("Advanced Kyrprax Medpac MK-2"),
            new Schematic(
                new Item("Prototype Kyrprax Medpac"),
                new Recipe(
                    new Ingredient[] {
                        new Ingredient(new Item("Artifact Curious Cell Graft"), 2),
                        new Ingredient(new Item("Premium Intravenous Injector"), 10),
                        new Ingredient(new Item("Prototype Intravenous Injector"), 10),
                        new Ingredient(new Item("Artifact Intravenous Injector"), 10),
                    },
                    new Ingredient(new Item("Advanced Kyrprax Medpac"), 6)
                )
            ),
            54888,
            null
        );

        private static Item advancedKyrpraxMedpacMk2 = new Item(
            "Advanced Kyrprax Medpac MK-2",
            0f,
            null,
            new Schematic(
                new Item("Advanced Kyrprax Medpac"),
                new Recipe(
                    new Ingredient[] {
                        new Ingredient(new Item("Artifact Curious Cell Graft"), 5),
                        new Ingredient(new Item("Premium Intravenous Injector"), 10),
                        new Ingredient(new Item("Prototype Intravenous Injector"), 10),
                        new Ingredient(new Item("Artifact Intravenous Injector"), 10),
                        new Ingredient(new Item("Legendary Ember"), 5),
                    },
                    new Ingredient(new Item("Advanced Kyrprax Medpac MK-2"), 1)
                )
            ),
            2399999,
            null
        );

        private static Item prototypeRecombinator = new Item(
            "Prototype Recombinator",
            null,
            590,
            400
        );

        private static Item artifactUnknownMicroorganism = new Item(
            "Artifact Unknown Microorganism",
            null,
            7500,
            null
        );

        private static Item artifactVirulentExtract = new Item(
            "Artifact Virulent Extract",
            null,
            4000,
            null
        );

        private static Item premiumRecombinator = new Item(
            "Premium Recombinator",
            null,
            350,
            1000
        );

        private static Item prototypeUnknownMicroorganism = new Item(
            "Prototype Unknown Microorganism",
            null,
            150,
            null
        );

        private static Item prototypeVirulentExtract = new Item(
            "Prototype Virulent Extract",
            null,
            1500,
            null
        );

        private static Item standardRecombinator = new Item(
            "Standard Recombinator",
            null,
            300,
            469
        );

        private static Item premiumUnknownMicroorganism = new Item(
            "Premium Unknown Microorganism",
            null,
            2000,
            null
        );

        private static Item premiumVirulentExtract = new Item(
            "Premium Virulent Extract",
            null,
            2000,
            null
        );

        private static Item premiumIntravenousInjector = new Item(
            "Premium Intravenous Injector",
            null,
            140,
            null
        );

        private static Item prototypeIntravenousInjector = new Item(
            "Prototype Intravenous Injector",
            null,
            985,
            null
        );

        private static Item artifactIntravenousInjector = new Item(
            "Artifact Intravenous Injector",
            null,
            3285,
            null
        );

        private static Item legendaryEmber = new Item(
            "Legendary Ember",
            null,
            485000,
            null
        );

        private static Dictionary<string, Item> items = new Dictionary<string, Item>() {
            { "Legendary Ember", legendaryEmber },
            { "Artifact Intravenous Injector", artifactIntravenousInjector },
            { "Prototype Intravenous Injector", prototypeIntravenousInjector },
            { "Premium Intravenous Injector", premiumIntravenousInjector },
            { "Premium Virulent Extract", premiumVirulentExtract },
            { "Premium Unknown Microorganism", premiumUnknownMicroorganism },
            { "Standard Recombinator", standardRecombinator },
            { "Prototype Virulent Extract", prototypeVirulentExtract },
            { "Prototype Unknown Microorganism", prototypeUnknownMicroorganism },
            { "Premium Recombinator", premiumRecombinator },
            { "Artifact Virulent Extract", artifactVirulentExtract },
            { "Premium Curious Cell Graft", premiumCuriousCellGraft },
            { "Premium Kyrprax Medpac", premiumKyrpraxMedpac },
            { "Prototype Kyrprax Medpac", prototypeKyrpraxMedpac },
            { "Prototype Curious Cell Graft", prototypeCuriousCellGraft },
            { "Artifact Curious Cell Graft", artifactCuriousCellGraft },
            { "Advanced Kyrprax Medpac", advancedKyrpraxMedpac },
            { "Advanced Kyrprax Medpac MK-2", advancedKyrpraxMedpacMk2 },
            { "Prototype Recombinator", prototypeRecombinator },
            { "Artifact Unknown Microorganism", artifactUnknownMicroorganism }
        };

        public static Ingredient GetIngredientsToCraftItem(string itemNameToCraft, int quantity, Ingredient parentIngredient = null)
        {
            if (!items.ContainsKey(itemNameToCraft))
            {
                return null;
            }

            var itemToCraft = items[itemNameToCraft];
            if (!itemToCraft.IsCraftable)
            {
                return null;
            }

            if (quantity % itemToCraft.Schematic.Recipe.Output.Quantity != 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity), $"Parameter value was not a multiple of {itemToCraft.Schematic.Recipe.Output.Quantity}");
            }

            var ingredient = new Ingredient(itemToCraft, quantity);
            if (parentIngredient != null)
            {
                parentIngredient.AddChild(ingredient);
            }

            var yieldAdjustedQuantity = quantity / itemToCraft.Schematic.Recipe.Output.Quantity;
            foreach (var recipeIngredient in itemToCraft.Schematic.Recipe.Inputs.GetIngredients())
            {
                var ingredientItem = items[recipeIngredient.Item.Name];
                var childIngredient = new Ingredient(ingredientItem, recipeIngredient.Quantity * yieldAdjustedQuantity);
                if (!ingredientItem.IsCraftable)
                {
                    ingredient.AddChild(childIngredient);
                }

                GetIngredientsToCraftItem(ingredientItem.Name, recipeIngredient.Quantity * yieldAdjustedQuantity, ingredient);
            }

            return ingredient;
        }

        public static Ingredient GetIngredientsToLearnSchematicsAndCraftItem(string itemNameToCraft, int quantity, Ingredient parentIngredient = null)
        {
            var ingredient = GetIngredientsToCraftItem(itemNameToCraft, quantity);
            var itemToCraft = items[itemNameToCraft];
            if (!itemToCraft.IsCraftable)
            {
                return ingredient;
            }

            if (parentIngredient != null)
            {
                parentIngredient.AddChild(ingredient);
            }

            if (itemToCraft?.Schematic?.DeconstructionSourceItem != null)
            {
                var deconstructItem = items[itemToCraft.Schematic.DeconstructionSourceItem.Name];
                GetIngredientsToLearnSchematicsAndCraftItem(deconstructItem.Name, deconstructItem.DeconstructItemExperiment.RequiredItemCount * deconstructItem.Schematic.Recipe.Output.Quantity, ingredient);
            }

            return ingredient;
        }

        public static Item GetItem(string itemName)
        {
            if (items.ContainsKey(itemName))
            {
                return items[itemName];
            }

            throw new KeyNotFoundException();
        }
    }
}