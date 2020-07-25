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
                    "Premium Curious Cell Graft",
                    new Ingredient[] {
                        new Ingredient(new Item("Standard Recombinator"), 8),
                        new Ingredient(new Item("Premium Unknown Microorganism"), 6),
                        new Ingredient(new Item("Premium Virulent Extract"), 6),
                    }
                )
            )
        );

        private static Item premiumKyrpraxMedpac = new Item(
            "Premium Kyrprax Medpac",
            0.2f,
            new Schematic("Prototype Kyrprax Medpac"),
            new Schematic(
                null,
                new Recipe(
                    "Premium Kyrprax Medpac",
                    new Ingredient[] {
                        new Ingredient(new Item("Premium Curious Cell Graft"), 2),
                        new Ingredient(new Item("Premium Intravenous Injector"), 10),
                    }
                )
            )
        );

        private static Item prototypeKyrpraxMedpac = new Item(
            "Prototype Kyrprax Medpac",
            0.2f,
            new Schematic("Advanced Kyrprax Medpac"),
            new Schematic(
                new Item("Premium Kyrprax Medpac"),
                new Recipe(
                    "Prototype Kyrprax Medpac",
                    new Ingredient[] {
                        new Ingredient(new Item("Premium Curious Cell Graft"), 2),
                        new Ingredient(new Item("Premium Intravenous Injector"), 10),
                        new Ingredient(new Item("Prototype Intravenous Injector"), 10),
                    }
                )
            )
        );

        private static Item prototypeCuriousCellGraft = new Item(
            "Prototype Curious Cell Graft",
            new Schematic(
                null,
                new Recipe(
                    "Prototype Curious Cell Graft",
                    new Ingredient[] {
                        new Ingredient(new Item("Premium Recombinator"), 8),
                        new Ingredient(new Item("Prototype Unknown Microorganism"), 6),
                        new Ingredient(new Item("Prototype Virulent Extract"), 6),
                        new Ingredient(new Item("Premium Curious Cell Graft"), 2),
                    }
                )
            )
        );

        private static Item artifactCuriousCellGraft = new Item(
            "Artifact Curious Cell Graft",
            new Schematic(
                null,
                new Recipe(
                    "Artifact Curious Cell Graft",
                    new Ingredient[] {
                        new Ingredient(new Item("Prototype Recombinator"), 12),
                        new Ingredient(new Item("Artifact Unknown Microorganism"), 12),
                        new Ingredient(new Item("Artifact Virulent Extract"), 12),
                        new Ingredient(new Item("Prototype Curious Cell Graft"), 3),
                    }
                )
            )
        );

        private static Item advancedKyrpraxMedpac = new Item(
            "Advanced Kyrprax Medpac",
            0.05f,
            new Schematic("Advanced Kyrprax Medpac MK-2"),
            new Schematic(
                new Item("Prototype Kyrprax Medpac"),
                new Recipe(
                    "Advanced Kyrprax Medpac",
                    new Ingredient[] {
                        new Ingredient(new Item("Artifact Curious Cell Graft"), 2),
                        new Ingredient(new Item("Premium Intravenous Injector"), 10),
                        new Ingredient(new Item("Prototype Intravenous Injector"), 10),
                        new Ingredient(new Item("Artifact Intravenous Injector"), 10),
                    }
                )
            )
        );

        private static Item advancedKyrpraxMedpacMk2 = new Item(
            "Advanced Kyrprax Medpac MK-2",
            0f,
            null,
            new Schematic(
                new Item("Advanced Kyrprax Medpac"),
                new Recipe(
                    "Advanced Kyrprax Medpac MK-2",
                    new Ingredient[] {
                        new Ingredient(new Item("Artifact Curious Cell Graft"), 5),
                        new Ingredient(new Item("Premium Intravenous Injector"), 10),
                        new Ingredient(new Item("Prototype Intravenous Injector"), 10),
                        new Ingredient(new Item("Artifact Intravenous Injector"), 10),
                        new Ingredient(new Item("Legendary Ember"), 5),
                    }
                )
            )
        );

        private static Dictionary<string, Item> items = new Dictionary<string, Item>() {
            { "Premium Curious Cell Graft", premiumCuriousCellGraft },
            { "Premium Kyrprax Medpac", premiumKyrpraxMedpac },
            { "Prototype Kyrprax Medpac", prototypeKyrpraxMedpac },
            { "Prototype Curious Cell Graft", prototypeCuriousCellGraft },
            { "Artifact Curious Cell Graft", artifactCuriousCellGraft },
            { "Advanced Kyrprax Medpac", advancedKyrpraxMedpac },
            { "Advanced Kyrprax Medpac MK-2", advancedKyrpraxMedpacMk2 }
        };

        public static IIngredients GetRequiredIngredients(string itemNameToCraft, int quantity, Ingredients ingredients = null)
        {
            if (ingredients == null)
            {
                ingredients = new Ingredients();
            }

            if (!items.ContainsKey(itemNameToCraft))
            {
                return ingredients;
            }

            var itemToCraft = items[itemNameToCraft];
            if (itemToCraft.Schematic == null)
            {
                return ingredients;
            }

            ingredients.AddIngredient(new Ingredient(itemToCraft, quantity));
            foreach (var ingredient in itemToCraft.Schematic.Recipe.Ingredients.GetIngredients())
            {
                if (!items.ContainsKey(ingredient.Item.Name) || items[ingredient.Item.Name].Schematic == null)
                {
                    ingredients.AddIngredient(new Ingredient(ingredient.Item, ingredient.Quantity * quantity));
                }

                GetRequiredIngredients(ingredient.Item.Name, ingredient.Quantity * quantity, ingredients);
            }

            if (itemToCraft.Schematic.DeconstructionSourceItem != null)
            {
                var deconstructItem = items[itemToCraft.Schematic.DeconstructionSourceItem.Name];
                GetRequiredIngredients(deconstructItem.Name, deconstructItem.DeconstructItemExperiment.RequiredItemCount, ingredients);
            }

            return ingredients;
        }
    }
}