using WorkflowEngine.Domain.Entities.Activity;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Application.Interfaces
{
    public interface IDecisionExecutor
    {
        ValueTask<ActivityResult> ExecuteAsync(
            DecisionActivity activity,
            WorkflowContext context,
            CancellationToken cancellationToken);
    }
}
