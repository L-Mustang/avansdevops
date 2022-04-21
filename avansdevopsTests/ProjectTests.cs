using Microsoft.VisualStudio.TestTools.UnitTesting;
using avansdevops;
using avansdevops.SprintStrategy;

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
            Assert.ReferenceEquals(sprint, project.GetSprint());
        }

        //[TestMethod]
        //public void Test_()
        //{
        //    // Arrange

        //    // Act

        //    // Assert
        //}

        //[TestMethod]
        //public void Test_()
        //{
        //    // Arrange

        //    // Act

        //    // Assert
        //}
    }
}