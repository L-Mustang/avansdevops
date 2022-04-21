using Microsoft.VisualStudio.TestTools.UnitTesting;
using avansdevops;
using avansdevops.BacklogItems;

using FluentAssertions;
using avansdevops.BacklogItems.Actions;

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
            BacklogItem backlogItem = new BacklogItem(id, title, 1);

            // Assert
            backlogItem.GetTitle().Should().Be(title);
        }

        [TestMethod]
        public void Test_BacklogItemSetState()
        {
            // Arrange

            // Act
            testItem2.SetState(testItem2.GetStateDoing());

            // Assert
            testItem2.GetState().Should().BeOfType<BacklogItemStateDoing>();
        }

        [TestMethod]
        public void Test_BacklogItemSetStateFail()
        {
            // Arrange

            // Act
            testItem2.SetState(testItem2.GetStateDoing());

            // Assert
            testItem2.GetState().Should().NotBeOfType<BacklogItemStateTodo>();
        }

        [TestMethod]
        public void Test_AddAction()
        {
            // Arrange
            Action action = new Action(1, testItem1, "name", 1);

            // Act
            testItem1.AddAction(action);

            // Assert
            testItem1.GetActions()[0].Should().Be(action);
        }

        [TestMethod]
        public void Test_RemoveAction()
        {
            // Arrange
            Action action1 = new Action(1, testItem1, "name1", 1);
            Action action2 = new Action(2, testItem1, "name2", 2);
            Action action3 = new Action(3, testItem1, "name3", 3);
            testItem1.AddAction(action1);
            testItem1.AddAction(action2);
            testItem1.AddAction(action3);

            // Act
            testItem1.RemoveAction(action2);

            // Assert
            testItem1.GetActions().Should().NotContain(action2);
        }
    }
}
