using Xunit;

namespace SwtorCrafting.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestRequiredItemCount9020()
        {
            var experiment = new DeconstructItemExperiment(0.9f, 0.2f);
            Assert.Equal(11, experiment.RequiredItemCount);
        }

        [Fact]
        public void TestRequiredItemCount9050()
        {
            var experiment = new DeconstructItemExperiment(0.9f, 0.5f);
            Assert.Equal(4, experiment.RequiredItemCount);
        }
    }
}
