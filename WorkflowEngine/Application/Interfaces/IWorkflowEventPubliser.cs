using WorkflowEngine.Domain.Entities.Activity;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Application.Interfaces
{
    public interface IWorkflowEventPubliser
    {
        ValueTask PublishActivityStartedAsync(
            ActivityInstance activity,
            CancellationToken cancellationToken);

        ValueTask PublishActivityCompetedAsync(
            ActivityInstance activity,
            ActivityResult result,
            CancellationToken cancelToken);

        ValueTask PublishWorkflowCompetedAsync(
            WorkflowInstance workflow,
            CancellationToken cancellationToken);
    }
}
