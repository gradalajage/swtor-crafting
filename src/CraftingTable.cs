using System.Collections.Generic;

namespace SwtorCrafting
{
    public class CraftingTable
    {
        private static Item premiumCuriousCellGraft = new Item(
            "Premium Curious Cell Graft",
            new Schematic(
                null,
                new SchematicRequirement[] {
                    new SchematicRequirement(new Item("Standard Recombinator"), 8),
                    new SchematicRequirement(new Item("Premium Unknown Microorganism"), 6),
                    new SchematicRequirement(new Item("Premium Virulent Extract"), 6),
                }
            )
        );

        private static Item premiumKyrpraxMedpac = new Item(
            "Premium Kyrprax Medpac",
            0.2f,
            new Item("Prototype Kyrprax Medpac"),
            new Schematic(
                null,
                new SchematicRequirement[] {
                    new SchematicRequirement(new Item("Premium Curious Cell Graft"), 2),
                    new SchematicRequirement(new Item("Premium Intravenous Injector"), 10),
                }
            )
        );

        private static Item prototypeKyrpraxMedpac = new Item(
            "Prototype Kyrprax Medpac",
            0.2f,
            new Item("Advanced Kyrprax Medpac"),
            new Schematic(
                new Item("Premium Kyrprax Medpac"),
                new SchematicRequirement[] {
                    new SchematicRequirement(new Item("Premium Curious Cell Graft"), 2),
                    new SchematicRequirement(new Item("Premium Intravenous Injector"), 10),
                    new SchematicRequirement(new Item("Prototype Intravenous Injector"), 10),
                }
            )
        );

        private static Item prototypeCuriousCellGraft = new Item(
            "Prototype Curious Cell Graft",
            new Schematic(
                null,
                new SchematicRequirement[] {
                    new SchematicRequirement(new Item("Premium Recombinator"), 8),
                    new SchematicRequirement(new Item("Prototype Unknown Microorganism"), 6),
                    new SchematicRequirement(new Item("Prototype Virulent Extract"), 6),
                    new SchematicRequirement(new Item("Premium Curious Cell Graft"), 2),
                }
            )
        );

        private static Item artifactCuriousCellGraft = new Item(
            "Artifact Curious Cell Graft",
            new Schematic(
                null,
                new SchematicRequirement[] {
                    new SchematicRequirement(new Item("Prototype Recombinator"), 12),
                    new SchematicRequirement(new Item("Artifact Unknown Microorganism"), 12),
                    new SchematicRequirement(new Item("Artifact Virulent Extract"), 12),
                    new SchematicRequirement(new Item("Prototype Curious Cell Graft"), 3),
                }
            )
        );

        private static Item advancedKyrpraxMedpac = new Item(
            "Advanced Kyrprax Medpac",
            0.05f,
            new Item("Advanced Kyrprax Medpac MK-2"),
            new Schematic(
                new Item("Prototype Kyrprax Medpac"),
                new SchematicRequirement[] {
                    new SchematicRequirement(new Item("Artifact Curious Cell Graft"), 2),
                    new SchematicRequirement(new Item("Premium Intravenous Injector"), 10),
                    new SchematicRequirement(new Item("Prototype Intravenous Injector"), 10),
                    new SchematicRequirement(new Item("Artifact Intravenous Injector"), 10),
                }
            )
        );

        private static Item advancedKyrpraxMedpacMk2 = new Item(
            "Advanced Kyrprax Medpac MK-2",
            0f,
            null,
            new Schematic(
                new Item("Advanced Kyrprax Medpac"),
                new SchematicRequirement[] {
                    new SchematicRequirement(new Item("Artifact Curious Cell Graft"), 5),
                    new SchematicRequirement(new Item("Premium Intravenous Injector"), 10),
                    new SchematicRequirement(new Item("Prototype Intravenous Injector"), 10),
                    new SchematicRequirement(new Item("Artifact Intravenous Injector"), 10),
                    new SchematicRequirement(new Item("Artifact Intravenous Injector"), 5),
                    new SchematicRequirement(new Item("Legendary Ember"), 5),
                }
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

        public static IEnumerable<Item> ComputeRequiredItemsToCraft(string itemNameToCraft, int quantity)
        {
            var requiredItems = new List<Item>();
            var itemToCraft = items[itemNameToCraft];
            if (itemToCraft.Schematic == null)
            {
                return requiredItems;
            }

            for (var j = 0; j < quantity; j++)
            {
                foreach (var component in itemToCraft.Schematic.SchematicRequirements)
                {
                    if (!items.ContainsKey(component.Item.Name))
                    {
                        for (var i = 0; i < component.Quantity; i++)
                        {
                            requiredItems.Add(component.Item);
                        }
                    }
                    else
                    {
                        for (var i = 0; i < component.Quantity; i++)
                        {
                            requiredItems.AddRange(ComputeRequiredItemsToCraft(component.Item.Name, component.Quantity));
                        }
                    }
                }
            }

            // if (itemToCraft.Schematic.DeconstructionSourceItem != null)
            // {
            //     var deconstructItem = items[itemToCraft.Schematic.DeconstructionSourceItem.Name];
            //     requiredItems.AddRange(ComputeRequiredItemsToCraft(deconstructItem.Name, deconstructItem.DeconstructItemExperiment.RequiredItemCount));
            // }

            return requiredItems;
        }
    }
}