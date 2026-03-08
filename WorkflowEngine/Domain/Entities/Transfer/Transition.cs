using System;
using System.Collections.Generic;
using System.Text;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Domain.Entities.Transfer
{
    public class Transition
    {
        public Guid FromActivityId { get; init; }
        public Guid ToActivityId { get; init; }
        public Func<WorkflowContext, bool>? Conditoin {  get; init; }
        public string Name { get; init; } = string.Empty;
    }
}
