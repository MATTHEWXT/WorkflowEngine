using System;
using System.Collections.Generic;
using System.Text;
using WorkflowEngine.Domain.Entities.Activity;
using WorkflowEngine.Domain.Enums;

namespace WorkflowEngine.Domain.Entities.Task
{
    public class TaskAssignment
    {
        public Guid Id { get; init; }
        public Guid ActivityId { get; init; }
        public string AssignedToRole { get; init; } = string.Empty;
        public string? AssignedToUser { get; set; }
        public ActivityTaskStatus Status { get; set; } = ActivityTaskStatus.Pending;
        public ActivityResult? Result { get; set; }
    }
}
