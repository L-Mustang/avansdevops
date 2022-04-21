using Microsoft.VisualStudio.TestTools.UnitTesting;
using avansdevops;
using avansdevops.SprintStrategy;
using avansdevops.DevOps;

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
            Assert.AreEqual(sprint, project.GetSprint());
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
            Assert.AreEqual(repo, project.GetRepository());
        }

    }
}