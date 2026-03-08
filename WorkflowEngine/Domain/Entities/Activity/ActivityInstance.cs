
using WorkflowEngine.Domain.Enums;

namespace WorkflowEngine.Domain.Entities.Activity
{
    public class ActivityInstance
    {
        public Guid Id { get; init; }
        public ActivityDefinition Definition { get; init; } = null!;
        public ActivityState State { get; set; } = ActivityState.Created;
        public DateTime? CreatedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}
