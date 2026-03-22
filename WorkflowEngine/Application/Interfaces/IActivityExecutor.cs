using WorkflowEngine.Domain.Entities.Activity;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Application.Interfaces
{
    public interface IActivityExecutor
    {
        ValueTask<ActivityResult> ExecuteAsync(
            WorkflowInstance workflow,
            ActivityInstance activity,
            CancellationToken cancellationToken);
    }
}
