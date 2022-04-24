using Microsoft.VisualStudio.TestTools.UnitTesting;
using avansdevops;
using avansdevops.BacklogItems;
using avansdevops.BacklogItems.Actions;
using FluentAssertions;
using System.Security.Cryptography;
using avansdevops.User;


namespace avansdevopsTests
{
    [TestClass]
    public class ProductBacklogTests
    {
        private string title1 = "Testitem123";
        private string title2 = "Testitem321";

        private int id1 = 1;
        private int id2 = 2;

        BacklogItem? testItem1;
        BacklogItem? testItem2;

        UserFactory devFactory = new DeveloperFactory("Dev", "developer", "dev@example.com");
        UserFactory testFactory = new TesterFactory("Test", "Tester", "test@example.com");
        IUser? dev;
        IUser? tester;

        [TestInitialize]
        public void Setup()
        {
            dev = devFactory.CreateUser();
            tester = testFactory.CreateUser();

            testItem1 = new BacklogItem(id1, title1, dev);
            testItem2 = new BacklogItem(id2, title2, dev);
        }

        [TestMethod]
        public void Test_ProductBacklogCreate()
        {
            // Act
            ProductBacklog pb = new ProductBacklog();

            // Assert
            pb.Should().NotBeNull();
            pb.GetType().Should().Be(typeof(ProductBacklog));
        }

        [TestMethod]
        public void Test_ProductBacklogAddBacklogItem()
        {
            // Arrange
            ProductBacklog pb = new ProductBacklog();

            // Act
            pb.AddBacklogItem(testItem1);

            // Assert
            pb.BacklogItems[0].Should().Be(testItem1);
        }

        [TestMethod]
        public void Test_ProductBacklogAddBacklogItemFail()
        {
            // Arrange
            ProductBacklog pb = new ProductBacklog();

            // Act
            pb.AddBacklogItem(testItem1);

            // Assert
            pb.BacklogItems[0].Should().NotBe(testItem2);
        }

        [TestMethod]
        public void Test_ProductBacklogRemoveItems()
        {
            
            // Arrange
            ProductBacklog pb = new ProductBacklog();
            pb.AddBacklogItem(testItem1);
            pb.AddBacklogItem(testItem2);

            // Act
            pb.RemoveBacklogItem(testItem1);

            // Assert
            pb.BacklogItems.Should().NotContain(testItem1);
            
        }
    }
}
