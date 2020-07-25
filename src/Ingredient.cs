namespace SwtorCrafting
{
    public class Ingredient
    {
        public Ingredient(Item item, int quantity)
        {
            this.Item = item;
            this.Quantity = quantity;
        }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{this.Item.Name}: {this.Quantity}";
        }
    }
}