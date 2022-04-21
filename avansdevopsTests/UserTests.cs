using Microsoft.VisualStudio.TestTools.UnitTesting;
using avansdevops;
using avansdevops.SprintStrategy;
using avansdevops.User;
using FluentAssertions;

namespace avansdevopsTests
{
    [TestClass]
    public class UserTests
    {
        UserFactory? factory;
        IUser? user;

        [TestInitialize()]
        public void Startup()
        {
        }

        [TestMethod]
        public void Test_DeveloperFactory()
        {
            // Arrange

            // Act
            factory = new DeveloperFactory("Jan", "Jantjes", "mail@mail.com");
            user = factory.CreateUser();
            // Assert
            user.Should().BeOfType<Developer>();
        }

        [TestMethod]
        public void Test_ProductOwnerFactory()
        {
            // Arrange

            // Act
            factory = new ProductOwnerFactory("Jan", "Jantjes", "mail@mail.com");
            user = factory.CreateUser();
            // Assert
            user.Should().BeOfType<ProductOwner>();
        }

        [TestMethod]
        public void Test_ScrumMasterFactory()
        {
            // Arrange

            // Act
            factory = new ScrumMasterFactory("Jan", "Jantjes", "mail@mail.com");
            user = factory.CreateUser();
            // Assert
            user.Should().BeOfType<ScrumMaster>();
        }

        [TestMethod]
        public void Test_TesterFactory()
        {
            // Arrange

            // Act
            factory = new TesterFactory("Jan", "Jantjes", "mail@mail.com");
            user = factory.CreateUser();
            // Assert
            user.Should().BeOfType<Tester>();
        }

        [TestMethod]
        public void Test_Developer_FullName()
        {
            // Arrange
            factory = new DeveloperFactory("Jan", "Jantjes", "mail@mail.com");
            user = factory.CreateUser();
            // Act

            // Assert
            user.FullName.Should().Be("Jan Jantjes");
        }

        [TestMethod]
        public void Test_ProductOwner_FullName()
        {
            // Arrange
            factory = new ProductOwnerFactory("Jan", "Jantjes", "mail@mail.com");
            user = factory.CreateUser();
            // Act

            // Assert
            user.FullName.Should().Be("Jan Jantjes");
        }

        [TestMethod]
        public void Test_ScrumMaster_FullName()
        {
            // Arrange
            factory = new ScrumMasterFactory("Jan", "Jantjes", "mail@mail.com");
            user = factory.CreateUser();
            // Act

            // Assert
            user.FullName.Should().Be("Jan Jantjes");
        }

        [TestMethod]
        public void Test_Tester_FullName()
        {
            // Arrange
            factory = new TesterFactory("Jan", "Jantjes", "mail@mail.com");
            user = factory.CreateUser();
            // Act

            // Assert
            user.FullName.Should().Be("Jan Jantjes");
        }
    }
}