using Microsoft.VisualStudio.TestTools.UnitTesting;
using avansdevops;
using avansdevops.BacklogItems;
using FluentAssertions;
using System.Security.Cryptography;

namespace avansdevopsTests
{
    [TestClass]
    public class BacklogItemTests
    {
        private static string title1 = "Testitem123";
        private static string title2 = "Testitem321";

        private static int id1 = 1;
        private static int id2 = 2;

        readonly BacklogItem testItem1 = new BacklogItem(id1, title1, 1);
        readonly BacklogItem testItem2 = new BacklogItem(id2, title2, 2);



        [TestMethod]
        public void Test_BacklogItemCreate()
        {
            // Arrange
            string title = "Testitem123";
            int id = 1;
            
            // Act
            BacklogItem backlogItem = new BacklogItem(id, title, null);

            // Assert
            backlogItem.Should().BeEquivalentTo(testItem1);
            
        }

        [TestMethod]
        public void Test_BacklogItemSetState()
        {
            // Arrange
            string title = "Testitem123";
            int id = 1;
            BacklogItem backlogItem = new BacklogItem(id, title, null);

            // Act
            backlogItem.SetState(backlogItem.GetStateDoing());

            // Assert
            backlogItem.Should().NotBeEquivalentTo(testItem2);
        }
    }
}
