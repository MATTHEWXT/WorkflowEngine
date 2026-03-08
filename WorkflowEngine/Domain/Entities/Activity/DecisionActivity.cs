using System;
using System.Collections.Generic;
using System.Text;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Domain.Entities.Activity
{
    public class DecisionActivity : ActivityDefinition
    {
        public Dictionary<string, Guid> Branches { get; init; } = new();
    }
}
