using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IssueTrackerLite.Models
{
    public enum IssueStatus { Open, InProgress, Resolved, Closed }
    public enum Priority { Low, Medium, High, Critical }

    public class Issue : IValidatableObject
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [StringLength(1000)]
        public string? Description { get; set; }

        public Priority Priority { get; set; } = Priority.Medium;
        public IssueStatus Status { get; set; } = IssueStatus.Open;

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }

        [StringLength(100)]
        public string? Assignee { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DueDate.HasValue && DueDate.Value.Date < CreatedAt.Date)
            {
                yield return new ValidationResult(
                    "Due date cannot be earlier than created date.",
                    new[] { nameof(DueDate) });
            }
        }
    }
}
