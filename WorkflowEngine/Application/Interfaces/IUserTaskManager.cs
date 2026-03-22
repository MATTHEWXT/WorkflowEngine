using WorkflowEngine.Domain.Entities.Activity;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Application.Interfaces
{
    public interface IUserTaskManager
    {
        ValueTask<ActivityResult> WaitForUserAsync(
            ActivityInstance activity,
            UserTaskActivity definition,
            WorkflowInstance workflow,
            CancellationToken cancellationToken);

        ValueTask CompleteTaskAsync(
            Guid activityId,
            ActivityResult result,
            CancellationToken cancelToken);

        ValueTask CancelTaskAsync(
            Guid activityId,
            CancellationToken cancellationToken);
    }
}
