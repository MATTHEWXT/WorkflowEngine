using WorkflowEngine.Domain.Entities.Activity;
using WorkflowEngine.Domain.Enums;

namespace WorkflowEngine.Domain.Entities.Workflow
{
    public class WorkflowInstance
    {
        public Guid Id { get; init; }
        public WorkflowDefinition Definition { get; init; } = null!;
        public List<ActivityInstance> ActivityInstances { get; } = new();
        public WorkflowContext Context { get; } = new();
        public List<WorkflowHistoryRecord> History { get; } = new();
        public WorkflowState State { get; set; } = WorkflowState.Created;
    }
}
