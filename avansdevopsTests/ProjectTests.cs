using Microsoft.VisualStudio.TestTools.UnitTesting;
using avansdevops;

namespace avansdevopsTests
{
    [TestClass]
    public class ProjectTests
    {
        [TestMethod]
        public void CreateProject()
        {
            //Arrange
            Project project = new Project();

            //Act

            //Assert
            Assert.IsNotNull(project);
        }
    }
}