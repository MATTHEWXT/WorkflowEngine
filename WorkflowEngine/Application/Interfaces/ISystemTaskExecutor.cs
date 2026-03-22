using WorkflowEngine.Domain.Entities.Activity;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Application.Interfaces
{
    public interface ISystemTaskExecutor
    {
        ValueTask<ActivityResult> ExecuteAsync(
            SystemTaskActivity activity,
            WorkflowContext context,
            CancellationToken cancellationToken);
    }
}
