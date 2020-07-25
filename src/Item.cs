using System;
using System.Diagnostics.CodeAnalysis;

namespace SwtorCrafting
{
    public class Item : IEquatable<Item>
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

        public Item(string name, float deconstructYieldsSchematicProbability, Schematic schematicLearnedUponDeconstruct, Schematic schematic)
        {
            this.DeconstructItemExperiment = new DeconstructItemExperiment(this.deconstructSuccessProbabilityThreshold, deconstructYieldsSchematicProbability);
            this.SchematicLearnedUponDeconstruct = schematicLearnedUponDeconstruct;
            this.Name = name;
            this.Schematic = schematic;
        }

        public Schematic SchematicLearnedUponDeconstruct { get; private set; }

        public Schematic Schematic { get; private set; }

        public string Name { get; private set; }

        public DeconstructItemExperiment DeconstructItemExperiment;

        public bool Equals([AllowNull] Item other)
        {
            if (other == null)
            {
                return false;
            }

            return this.Name.Equals(other.Name);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            
            return Equals(obj as Item);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}