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
    public class ActionTests
    {
        private int actionId1 = 1;
        private int actionId2 = 2;

        private string actionName1 = "Action1";
        private string actionName2 = "Action2";

        UserFactory devFactory = new DeveloperFactory("Dev", "developer", "dev@example.com");
        UserFactory testFactory = new TesterFactory("Test", "Tester", "test@example.com");
        IUser? dev;
        IUser? tester;

        Action action1;
        Action action2;

        [TestInitialize]
        public void Setup()
        {
            dev = devFactory.CreateUser();
            tester = testFactory.CreateUser();

            action1 = new Action(actionId1, actionName1, null);
            action2 = new Action(actionId2, actionName2, null);
        }


        [TestMethod]
        public void Test_ActionCreate()
        {
            // Arrange
            int id = 1;
            string name = "Action1";

            // Act
            Action action = new Action(id, name, null);

            // Assert
            action.Should().BeOfType(typeof(Action));
        }

        [TestMethod]
        public void Test_SetState()
        {
            //Act
            action1.SetState(action1.GetStateDone());

            // Assert
            action1.GetState().Should().BeOfType(typeof(ActionStateDone));
        }

        //[TestMethod]
    }
}
