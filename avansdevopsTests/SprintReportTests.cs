using Microsoft.VisualStudio.TestTools.UnitTesting;
using avansdevops;
using avansdevops.SprintStrategy;
using avansdevops.User;
using FluentAssertions;
using avansdevops.BacklogItems;
using avansdevops.SprintReport;
using System.IO;
using System;

namespace avansdevopsTests
{
    [TestClass]
    public class SprintReportTests
    {
        Sprint sprint;

        StringWriter stringWriter;

        [TestInitialize()]
        public void Startup()
        {
            sprint = new Sprint(new SprintStrategyFeedback());

            stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
        }

        [TestMethod]
        public void Test_SprintReportDocx()
        {
            // Arrange
            // Act
            SprintReport sprintReport = new SprintReport(sprint, DocumentType.Docx);

            // Assert
            sprintReport.createReportDocument().Should().BeTrue();
        }

        [TestMethod]
        public void Test_SprintReportPDF()
        {
            // Arrange
            // Act
            SprintReport sprintReport = new SprintReport(sprint, DocumentType.PDF);

            // Assert
            sprintReport.createReportDocument().Should().BeTrue();
        }

        [TestMethod]
        public void Test_SprintReportDocx_Output()
        {
            // Arrange
            // Act
            SprintReport sprintReport = new SprintReport(sprint, DocumentType.Docx);
            sprintReport.createReportDocument();
            // Assert
            stringWriter.ToString().Should().Contain("Docx");
        }

        [TestMethod]
        public void Test_SprintReportPDF_Output()
        {
            // Arrange
            // Act
            SprintReport sprintReport = new SprintReport(sprint, DocumentType.PDF);
            sprintReport.createReportDocument();
            // Assert
            stringWriter.ToString().Should().Contain("PDF");
        }
    }
}