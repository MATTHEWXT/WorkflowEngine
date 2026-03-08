using System;
using System.Collections.Generic;
using System.Text;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Domain.Entities.Activity
{
    public class UserTaskActivity : ActivityDefinition
    {
        public string AssignedRole { get; init; } = string.Empty;
        public List<string> AvailableActions { get; init; } = new();
    }
}
