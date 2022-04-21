using Microsoft.VisualStudio.TestTools.UnitTesting;
using avansdevops;
using avansdevops.SprintStrategy;
using avansdevops.DevOps;
using FluentAssertions;

namespace avansdevopsTests
{
    [TestClass]
    public class ProjectTests
    {
        [TestMethod]
        public void Test_CreateProject()
        {
            // Arrange
            Project project = new Project();

            // Act

            // Assert
            Assert.IsNotNull(project);
        }

        [TestMethod]
        public void Test_AddSprint()
        {
            // Arrange
            Project project = new Project();

            ISprintStrategy sprintStrategy = new SprintStrategyFeedback();
            Sprint sprint = new Sprint(sprintStrategy);

            // Act
            project.AddSprint(sprintStrategy);

            // Assert
            sprint.Should().BeEquivalentTo(project.GetSprint());
        }

        [TestMethod]
        public void Test_AddRepository()
        {
            // Arrange
            Project project = new Project();
            Repository repo = new Repository("testing123");

            // Act
            project.AddRepository("testing123");

            // Assert
            repo.GetName().Should().BeEquivalentTo(project.GetRepository().GetName());
        }

    }
}