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
    public class BranchTests
    {
        Branch branch;

        StringWriter stringWriter;

        [TestInitialize()]
        public void Startup()
        {
            branch = new Branch("main");

            stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
        }


        [TestMethod]
        public void Test_Push()
        {
            // Arrange

            // Act
            branch.Push();

            // Assert
            stringWriter.ToString().Should().ContainAll("Pushed changes", branch.Name);
        }

        [TestMethod]
        public void Test_Pull()
        {
            // Arrange

            // Act
            branch.Pull();

            // Assert
            stringWriter.ToString().Should().ContainAll("Pulled changes", "origin");
        }

        [TestMethod]
        public void Test_Commit()
        {
            // Arrange

            // Act
            branch.Commit();

            // Assert
            stringWriter.ToString().Should().ContainAll("Created commit", branch.Name);
        }

        [TestMethod]
        public void Test_Checkout()
        {
            // Arrange

            // Act
            branch.Checkout();

            // Assert
            stringWriter.ToString().Should().ContainAll("Checked out", branch.Name);
        }
    }
}
