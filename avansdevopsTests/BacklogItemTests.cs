using Microsoft.VisualStudio.TestTools.UnitTesting;
using avansdevops;
using avansdevops.BacklogItems;

using FluentAssertions;
using avansdevops.BacklogItems.Actions;
using System.IO;
using System;
using Action = avansdevops.BacklogItems.Actions.Action;
using System.Diagnostics;

namespace avansdevopsTests
{
    [TestClass]
    public class BacklogItemTests
    {
        private string title1 = "Testitem123";
        private string title2 = "Testitem321";

        private int id1 = 1;
        private int id2 = 2;

        BacklogItem? testItem1;
        BacklogItem? testItem2;

        StringWriter stringWriter;

        [TestInitialize]
        public void Startup()
        {
            testItem1 = new BacklogItem(id1, title1, 1);
            testItem2 = new BacklogItem(id2, title2, 2);

            stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
        }

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
            Action action = new Action(1, "name", 1);

            // Act
            testItem1.AddAction(action);

            // Assert
            testItem1.GetActions()[0].Should().Be(action);
        }

        [TestMethod]
        public void Test_RemoveAction()
        {
            // Arrange
            Action action1 = new Action(1, "name1", 1);
            Action action2 = new Action(2, "name2", 2);
            Action action3 = new Action(3, "name3", 3);
            testItem1.AddAction(action1);
            testItem1.AddAction(action2);
            testItem1.AddAction(action3);

            // Act
            testItem1.RemoveAction(action2);

            // Assert
            testItem1.GetActions().Should().NotContain(action2);
        }

        [TestMethod]
        public void Test_BacklogItemNotification()
        {
            // Arrange
            //testItem1._backlogItemManager.Subscribe(new BacklogItemListener());

            // Act
            testItem1.SetState(testItem1.GetStateDoing());

            // Assert
            Trace.WriteLine(stringWriter.ToString());
            stringWriter.ToString().Should().ContainAll("Slack","Smtp","BacklogItemStateDoing");
        }
    }
}
