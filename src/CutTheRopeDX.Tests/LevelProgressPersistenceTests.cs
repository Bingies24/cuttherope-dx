using CutTheRopeDX.GameMain;

using Xunit;

namespace CutTheRopeDX.Tests
{
    public class LevelProgressPersistenceTests
    {
        [Fact]
        public void ShouldPersistTrueWhenImprovedInNormalPlay()
        {
            Assert.True(LevelProgressPersistence.ShouldPersistScore(
                customLevelActive: false,
                newValue: 1200,
                storedValue: 900));
        }

        [Fact]
        public void ShouldPersistFalseWhenNotImprovedInNormalPlay()
        {
            Assert.False(LevelProgressPersistence.ShouldPersistScore(
                customLevelActive: false,
                newValue: 900,
                storedValue: 900));
        }

        [Fact]
        public void ShouldPersistFalseInCustomLevelEvenWhenImproved()
        {
            Assert.False(LevelProgressPersistence.ShouldPersistScore(
                customLevelActive: true,
                newValue: 1200,
                storedValue: 900));
        }

        [Fact]
        public void ShouldPersistFalseInCustomLevelFromZero()
        {
            Assert.False(LevelProgressPersistence.ShouldPersistScore(
                customLevelActive: true,
                newValue: 3,
                storedValue: 0));
        }
    }
}
