namespace SwtorCrafting
{
    public class SchematicRequirement
    {
        public SchematicRequirement(Item item, int quantity)
        {
            this.Item = item;
            this.Quantity = quantity;
        }

        public Item Item { get; private set; }

        public int Quantity { get; private set; }
    }
}