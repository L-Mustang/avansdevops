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
using avansdevops.DevOps.Testers;
using avansdevops.Lib;
using avansdevops.SprintReport;

namespace avansdevopsTests
{
    [TestClass]
    public class DevOpsTests
    {
        Branch branch;
        DevOps devops;

        StringWriter stringWriter;

        [TestInitialize()]
        public void Startup()
        {
            branch = new Branch("main");
            devops = new DevOps();

            stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
        }


        [TestMethod]
        public void Test_InstallPackage()
        {
            // Arrange
            string packageUrl = "npm.org";

            // Act
            devops.InstallPackage(packageUrl, branch);

            // Assert
            stringWriter.ToString().Should().ContainAll("Downloading package", packageUrl);
        }

        [TestMethod]
        public void Test_Deploy()
        {
            // Arrange

            // Act
            devops.Deploy(branch);

            // Assert
            stringWriter.ToString().Should().ContainAll("Deployed");
        }

        [TestMethod]
        public void Test_TestNUnit()
        {
            // Arrange

            // Act
            devops.Test(branch, new NUnitAdapter(new NUnit()));

            // Assert
            stringWriter.ToString().Should().ContainAll("Testing", "NUnit");
        }

        [TestMethod]
        public void Test_TestSelenium()
        {
            // Arrange

            // Act
            devops.Test(branch, new SeleniumAdapter(new Selenium()));

            // Assert
            stringWriter.ToString().Should().ContainAll("Testing", "Selenium");
        }

        [TestMethod]
        public void Test_BuildDotNet()
        {
            // Arrange

            // Act
            devops.Build(branch, new DotNetAdapter(new DotNet()));

            // Assert
            stringWriter.ToString().Should().ContainAll("Building DotNet", "branch", branch.Name);
        }

        [TestMethod]
        public void Test_BuildDotNetCore()
        {
            // Arrange

            // Act
            devops.Build(branch, new DotNetCoreAdapter(new DotNetCore()));

            // Assert
            stringWriter.ToString().Should().ContainAll("Building DotNetCore", "branch", branch.Name);
        }

        [TestMethod]
        public void Test_BuildMaven()
        {
            // Arrange

            // Act
            devops.Build(branch, new MavenAdapter(new Maven()));

            // Assert
            stringWriter.ToString().Should().ContainAll("Building Maven", "branch", branch.Name);
        }

        [TestMethod]
        public void Test_BuildAnt()
        {
            // Arrange

            // Act
            devops.Build(branch, new AntAdapter(new Ant()));

            // Assert
            stringWriter.ToString().Should().ContainAll("Building Ant", "branch", branch.Name);
        }

        [TestMethod]
        public void Test_BuildJenkins()
        {
            // Arrange

            // Act
            devops.Build(branch, new JenkinsAdapter(new Jenkins()));

            // Assert
            stringWriter.ToString().Should().ContainAll("Building Jenkins", "branch", branch.Name);
        }

        [TestMethod]
        public void Test_Analyse()
        {
            // Arrange

            // Act
            devops.Analyse(branch);

            // Assert
            stringWriter.ToString().Should().ContainAll("Analysis", "branch", branch.Name);
        }
    }
}
