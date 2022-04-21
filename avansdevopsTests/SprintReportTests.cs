using Microsoft.VisualStudio.TestTools.UnitTesting;
using avansdevops;
using avansdevops.SprintStrategy;
using avansdevops.User;
using FluentAssertions;
using avansdevops.BacklogItems;
using avansdevops.SprintReport;

namespace avansdevopsTests
{
    [TestClass]
    public class SprintReportTests
    {
        Sprint sprint;

        [TestInitialize()]
        public void Startup()
        {
            sprint = new Sprint(new SprintStrategyFeedback());
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

        public void Test_SprintReportPDF()
        {
            // Arrange
            // Act
            SprintReport sprintReport = new SprintReport(sprint, DocumentType.PDF);

            // Assert
            sprintReport.createReportDocument().Should().BeTrue();
        }
    }
}