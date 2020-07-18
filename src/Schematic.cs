using System.Collections.Generic;

namespace SwtorCrafting
{
    public class Schematic
    {
        public Schematic(string itemName)
        {
            this.DeconstructionSourceItem = new Item(itemName);
        }

        public Schematic(Item deconstructionSourceItem, IEnumerable<SchematicRequirement> schematicRequirements)
        {
            this.SchematicRequirements = schematicRequirements;
            this.DeconstructionSourceItem = deconstructionSourceItem;
        }

        public IEnumerable<SchematicRequirement> SchematicRequirements { get; private set; }

        public Item DeconstructionSourceItem { get; private set; }
    }
}