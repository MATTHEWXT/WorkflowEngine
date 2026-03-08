using WorkflowEngine.Domain.Entities.Activity;

namespace WorkflowEngine.Domain.Entities.Workflow
{
    public record WorkflowHistoryRecord
    {
        public Guid ActivityGuid { get; init; }
        public string ActivityName { get; init; } = string.Empty;
        public string? PerfomedBy { get; init; }
        public DateTime Timestamp { get; init; }
        public ActivityResult Result { get; init; } = null!;
    }
}
