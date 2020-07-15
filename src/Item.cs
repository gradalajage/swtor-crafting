namespace SwtorCrafting
{
    public class Item
    {
        private float deconstructSuccessProbabilityThreshold = 0.9f;

        public Item(string name)
        {
            this.Name = name;
        }

        public Item(string name, Schematic schematic)
        {
            this.Name = name;
            this.Schematic = schematic;
        }

        public Item(string name, float deconstructYieldsSchematicProbability, Item deconstructYieldsItem, Schematic schematic)
        {
            this.DeconstructItemExperiment = new DeconstructItemExperiment(this.deconstructSuccessProbabilityThreshold, deconstructYieldsSchematicProbability);
            this.DeconstructYieldsItem = deconstructYieldsItem;
            this.Name = name;
            this.Schematic = schematic;
        }

        public Item DeconstructYieldsItem { get; private set; }

        public Schematic Schematic { get; private set; }

        public string Name { get; private set; }

        public DeconstructItemExperiment DeconstructItemExperiment;
    }
}