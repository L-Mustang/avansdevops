using Microsoft.VisualStudio.TestTools.UnitTesting;
using avansdevops;
using avansdevops.BacklogItems;
using avansdevops.BacklogItems.Actions;
using FluentAssertions;
using System.Security.Cryptography;
using avansdevops.User;
using avansdevops.SprintStrategy;
using System.IO;
using System;
using avansdevops.DevOps;

namespace avansdevopsTests
{
    [TestClass]
    public class RepositoryTests
    {
        Project project;
        Repository repository;

        [TestInitialize()]
        public void Startup()
        {
            project = new Project();
            project.AddRepository("production");
            repository = project.GetRepository();
        }


        [TestMethod]
        public void Test_AddGetRepository()
        {
            // Arrange

            // Act
            project.AddRepository("test");

            // Assert
            project.GetRepository().Should().NotBeNull();
        }

        [TestMethod]
        public void Test_GetBranch()
        {
            // Arrange

            // Act

            // Assert
            project.GetRepository().GetBranch("main").Should().NotBeNull();
        }

        [TestMethod]
        public void Test_RemoveBranch()
        {
            // Arrange

            // Act
            Branch main = repository.GetBranch("main");
            repository.RemoveBranch(main);
            // Assert
            repository.GetBranch("main").Should().BeNull();
        }

        [TestMethod]
        public void Test_AddBranch()
        {
            // Arrange

            // Act
            Branch test = new Branch("test");
            repository.AddBranch(test);
            // Assert
            repository.GetBranch("test").Should().BeSameAs(test);
        }

        [TestMethod]
        public void Test_GetAllBranches()
        {
            // Arrange

            // Act
            Branch test = new Branch("test");
            repository.AddBranch(test);
            // Assert
            repository.GetAllBranches().Count.Should().Be(2);
        }
    }
}
