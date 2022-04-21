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

        UserFactory? factory;
        IUser? user;

        [TestInitialize()]
        public void Startup()
        {
            sprintFeedback = new Sprint(new SprintStrategyFeedback());
            sprintRelease = new Sprint(new SprintStrategyRelease());

            factory = new DeveloperFactory("Jan", "Jantjes", "mail@mail.com");
            user = factory.CreateUser();
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

        public void Test_SprintGetStatus()
        {
            // Arrange
            // Act
            // Assert
            sprintFeedback.GetStatus().Should().BeTrue();
        }

        [TestMethod]
        public void Test_SprintSetStatus()
        {
            // Arrange
            // Act
            sprintFeedback.SetStatus(false);
            // Assert
            sprintFeedback.GetStatus().Should().BeFalse();
        }

        [TestMethod]
        public void Test_SprintAddUser_GetUser()
        {
            // Arrange
            // Act
            sprintFeedback.AddUser(user);
            // Assert
            sprintFeedback.GetUser(user.FullName).Should().Be(user);
        }

        [TestMethod]
        public void Test_SprintAddUser_GetAllUsers()
        {
            // Arrange
            // Act
            sprintFeedback.AddUser(user);
            sprintFeedback.AddUser(user);
            // Assert
            sprintFeedback.GetAllUsers().Count.Should().Be(2);
        }

        [TestMethod]
        public void Test_SprintRemoveUser()
        {
            // Arrange
            // Act
            sprintFeedback.AddUser(user);
            sprintFeedback.RemoveUser(user);
            // Assert
            sprintFeedback.GetAllUsers().Count.Should().Be(0);
        }
    }
}