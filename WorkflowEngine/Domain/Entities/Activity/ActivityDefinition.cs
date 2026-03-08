using WorkflowEngine.Domain.Entities.Workflow;
using WorkflowEngine.Domain.Enums;

namespace WorkflowEngine.Domain.Entities.Activity
{
    public abstract class ActivityDefinition
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public ActivityType Type {  get; init; }
        public abstract Task<ActivityResult> Execute(WorkflowInstance workflowInstance);
    }
}
