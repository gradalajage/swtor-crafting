using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SwtorCrafting
{
    public class Ingredient
    {
        private const string cross = " ├─";
        private const string corner = " └─";
        private const string vertical = " │ ";
        private const string space = "   ";
        private readonly NumberFormatInfo swtorCurrencyFormat;

        public Ingredient(Item item, int quantity)
        {
            this.Item = item;
            this.Quantity = quantity;
            this.Children = new Ingredients();
            var nfi = CultureInfo.CurrentCulture.NumberFormat;
            this.swtorCurrencyFormat = (NumberFormatInfo)nfi.Clone();
            this.swtorCurrencyFormat.CurrencySymbol = "¤"; // Alt + 0164
            this.swtorCurrencyFormat.CurrencyDecimalDigits = 0;
        }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public Ingredient Parent { get; private set; }

        public IIngredients Children { get; private set; }

        public int Cost
        {
            get
            {
                if (this.Children.Count() > 0)
                {
                    return this.Children.GetTotalCost();
                }

                return this.Item.Cost * this.Quantity;
            }
        }

        public void AddChild(Ingredient ingredient)
        {
            ingredient.Parent = this;
            this.Children.AddIngredient(ingredient);
        }

        public override string ToString()
        {
            return PrintNode(this, string.Empty).ToString();
        }

        public IIngredients Collate()
        {
            var ingredients = new Ingredients();
            ingredients.AddIngredient(new Ingredient(new Item(this.Item.Name), this.Quantity));
            foreach (var ingredient in this.Children.GetIngredients())
            {
                ingredients.AddIngredients(ingredient.Collate());
            }

            return ingredients;
        }

        private StringBuilder PrintNode(Ingredient node, string indent, StringBuilder stringBuilder = null)
        {
            if (stringBuilder == null)
            {
                stringBuilder = new StringBuilder();
            }

            var credits = String.Format(this.swtorCurrencyFormat, "{0:C}", node.Cost);
            stringBuilder.AppendLine($"{node.Quantity} {node.Item.Name} ({credits})");
            var nodeChildren = node.Children.GetIngredients().ToList();
            var numberOfChildren = node.Children.Count();
            for (var i = 0; i < numberOfChildren; i++)
            {
                var child = nodeChildren[i];
                var isLast = (i == (numberOfChildren - 1));
                PrintChildNode(child, indent, isLast, stringBuilder);
            }

            return stringBuilder;
        }

        private void PrintChildNode(Ingredient node, string indent, bool isLast, StringBuilder stringBuilder)
        {
            stringBuilder.Append(indent);
            if (isLast)
            {
                stringBuilder.Append(corner);
                indent += space;
            }
            else
            {
                stringBuilder.Append(cross);
                indent += vertical;
            }

            PrintNode(node, indent, stringBuilder);
        }
    }
}