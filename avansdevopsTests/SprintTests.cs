using Microsoft.VisualStudio.TestTools.UnitTesting;
using avansdevops;
using avansdevops.SprintStrategy;
using avansdevops.User;
using FluentAssertions;

namespace avansdevopsTests
{
    [TestClass]
    public class SprintTests
    {
        Sprint? sprintFeedback;
        Sprint? sprintRelease;

        [TestInitialize()]
        public void Startup()
        {
            sprintFeedback = new Sprint(new SprintStrategyFeedback());
            sprintRelease = new Sprint(new SprintStrategyRelease());
        }

        [TestMethod]
        public void Test_SprintStrategyFeedback()
        {
            // Arrange
            // Act
            // Assert
            sprintFeedback.GetStrategy().Should().BeOfType<SprintStrategyFeedback>();
        }

        [TestMethod]
        public void Test_SprintStrategyRelease()
        {
            // Arrange
            // Act
            // Assert
            sprintRelease.GetStrategy().Should().BeOfType<SprintStrategyRelease>();
        }
    }
}