using Microsoft.VisualStudio.TestTools.UnitTesting;
using avansdevops;
using avansdevops.BacklogItems;
using avansdevops.BacklogItems.Actions;
using FluentAssertions;
using System.Security.Cryptography;

namespace avansdevopsTests
{
    [TestClass]
    public class ActionTests
    {
        private static int actionId1 = 1;
        private static int actionId2 = 2;

        private static string actionName1 = "Action1";
        private static string actionName2 = "Action2";

        private static Action action1 = new Action(actionId1, actionName1, 1);
        private static Action action2 = new Action(actionId2, actionName2, 2);


        [TestMethod]
        public void Test_ActionCreate()
        {
            // Arrange
            string name = "Action1";
            int id = 1;            

            // Act
            Action action = new Action(id, name, id);

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
    }
}
