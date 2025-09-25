using System;
using System.Linq;
using IssueTrackerLite.Models;
using Xunit;

namespace IssueTrackerLite.Tests
{
    public class IssueValidationTests
    {
        [Fact]
        public void DueDate_CannotBeBefore_CreatedAt()
        {
            var issue = new Issue
            {
                Title = "Sample",
                CreatedAt = new DateTime(2024, 01, 10),
                DueDate = new DateTime(2024, 01, 09)
            };

            var results = issue.Validate(new System.ComponentModel.DataAnnotations.ValidationContext(issue)).ToList();

            Assert.Contains(results, r => r.ErrorMessage!.Contains("Due date cannot be earlier"));
        }
    }
}
