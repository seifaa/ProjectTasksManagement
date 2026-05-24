using ProjectTasksManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectTasksManagement.Domain.Entities
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Status Status { get; set; } = Status.Pending;
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; } = Priority.Medium;
        public Guid ProjectId { get; set; }
        public Project Project { get; set; } = null!;
    }
}
