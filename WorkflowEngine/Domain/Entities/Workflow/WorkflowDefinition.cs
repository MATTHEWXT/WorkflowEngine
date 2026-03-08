using WorkflowEngine.Domain.Entities.Activity;
using WorkflowEngine.Domain.Entities.Transfer;

namespace WorkflowEngine.Domain.Entities.Workflow
{
    public class WorkflowDefinition
    {
        public Guid Id {  get; init; }
        public string Name { get; init; } = string.Empty;
        public List<ActivityDefinition> Activities { get; init; } = null!;
        public List<Transition> Transitions { get; init; } = null!;
        public ActivityDefinition StartActivity { get; init; } = null!;
    }
}
