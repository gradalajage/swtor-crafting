using System;

namespace SwtorCrafting
{
    public class DeconstructItemExperiment
    {
        public DeconstructItemExperiment(float successProbabilityThreshold, float yieldsSchematicProbability)
        {
            this.SuccessProbabilityThreshold = successProbabilityThreshold;
            this.YieldsSchematicProbability = yieldsSchematicProbability;
        }

        public float SuccessProbabilityThreshold { get; private set; }

        public float YieldsSchematicProbability { get; private set; }

        public int RequiredItemCount
        {
            get
            {
                var doesNotYieldSchematicProbability = 1 - this.YieldsSchematicProbability;
                return (int)Math.Ceiling(Math.Log(-this.SuccessProbabilityThreshold + 1, doesNotYieldSchematicProbability));
            }
        }
    }

}