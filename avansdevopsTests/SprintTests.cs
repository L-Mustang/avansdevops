using Microsoft.VisualStudio.TestTools.UnitTesting;
using avansdevops;
using avansdevops.SprintStrategy;
using avansdevops.User;
using FluentAssertions;
using avansdevops.BacklogItems;
using System.IO;
using System;
using System.Diagnostics;

namespace avansdevopsTests
{
    [TestClass]
    public class SprintTests
    {
        Sprint? sprintFeedback;
        Sprint? sprintRelease;

        StringWriter stringWriter;

        UserFactory? factory;
        IUser? user;

        BacklogItem backlogItem;

        [TestInitialize()]
        public void Startup()
        {
            sprintFeedback = new Sprint(new SprintStrategyFeedback());
            sprintRelease = new Sprint(new SprintStrategyRelease());

            stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            factory = new DeveloperFactory("Jan", "Jantjes", "mail@mail.com");
            user = factory.CreateUser();

            backlogItem = new BacklogItem(1, "Writing main", null);
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

        [TestMethod]
        public void Test_SprintAddBacklogItem_GetAllBacklogItem()
        {
            // Arrange
            // Act
            sprintFeedback.AddBacklogItem(backlogItem);
            // Assert
            sprintFeedback.GetAllBacklogItems()[0].Should().Be(backlogItem);
        }

        [TestMethod]
        public void Test_SprintRemoveBacklogItem()
        {
            // Arrange
            // Act
            sprintFeedback.AddBacklogItem(backlogItem);
            sprintFeedback.RemoveBacklogItem(backlogItem);
            // Assert
            sprintFeedback.GetAllBacklogItems().Count.Should().Be(0);
        }

        [TestMethod]
        public void Test_SprintSetBacklogItemState()
        {
            // Arrange
            // Act
            sprintFeedback.AddBacklogItem(backlogItem);
            // Act
            backlogItem.SetState(backlogItem.GetStateDoing());

            // Assert
            sprintFeedback.GetAllBacklogItems()[0].GetState().Should().BeOfType<BacklogItemStateDoing>();
        }

        [TestMethod]
        public void Test_SprintListenerSendNotification()
        {
            // Arrange
            sprintFeedback._sprintManager.Subscribe(new SprintListener());

            // Act
            sprintFeedback.SetStatus(false);

            // Assert
            //Trace.WriteLine(stringWriter.ToString());
            stringWriter.ToString().Should().ContainAll("sprint", "False", "Smtp", "Slack");
        }
    }
}