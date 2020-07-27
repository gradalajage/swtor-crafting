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

        public Item(string name, Schematic schematic, int? gtnCost, int? vendorCost)
            : this(name)
        {
            this.Schematic = schematic;
            this.GtnCost = gtnCost;
            this.VendorCost = vendorCost;
        }

        public Item(string name, float deconstructYieldsSchematicProbability, Schematic schematicLearnedUponDeconstruct, Schematic schematic, int? gtnCost, int? vendorCost)
            : this(name, schematic, gtnCost, vendorCost)
        {
            this.DeconstructItemExperiment = new DeconstructItemExperiment(this.deconstructSuccessProbabilityThreshold, deconstructYieldsSchematicProbability);
            this.SchematicLearnedUponDeconstruct = schematicLearnedUponDeconstruct;
        }

        public bool IsCraftable => this.Schematic != null;

        public int? GtnCost { get; private set; }

        public int? VendorCost { get; private set; }

        public int Cost
        {
            get
            {
                var hasGtnCost = this.GtnCost != null;
                var hasVendorCost = this.VendorCost != null;
                var hasBothGtnAndVendorCost = hasGtnCost && hasVendorCost;

                if (hasBothGtnAndVendorCost)
                {
                    return Math.Min(this.GtnCost.Value, this.VendorCost.Value);
                }

                if (hasGtnCost)
                {
                    return this.GtnCost.Value;
                }

                if (hasVendorCost)
                {
                    return this.VendorCost.Value;
                }

                return 0;
            }
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

        public override string ToString()
        {
            return this.Name;
        }
    }
}