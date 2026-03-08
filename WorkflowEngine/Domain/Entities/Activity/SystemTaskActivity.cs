using System;
using System.Collections.Generic;
using System.Text;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Domain.Entities.Activity
{
    public class SystemTaskActivity : ActivityDefinition
    {
        public string HandlerName { get; init; } = string.Empty;
        public Dictionary<string, object> Parameters { get; init; } = new();
    }
}
