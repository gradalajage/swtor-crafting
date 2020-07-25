using System.Collections.Generic;

namespace SwtorCrafting
{
    public class Schematic
    {
        public Schematic(string deconstructionSourceItemName)
        {
            this.DeconstructionSourceItem = new Item(deconstructionSourceItemName);
        }

        public Schematic(Item deconstructionSourceItem, Recipe recipe)
        {
            this.Recipe = recipe;
            this.DeconstructionSourceItem = deconstructionSourceItem;
        }

        public Recipe Recipe { get; private set; }

        public Item DeconstructionSourceItem { get; private set; }
    }
}