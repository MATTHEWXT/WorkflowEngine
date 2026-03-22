using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Application.Interfaces
{
    public interface IWorkflowRepository
    {
        ValueTask SaveAsync(
            WorkflowInstance instance,
            CancellationToken cancellationToken);

        ValueTask<WorkflowInstance?> GetByIdAsync(
            Guid id,
            CancellationToken cancellation);

        ValueTask UpdateAsync(
            WorkflowInstance instance,
            CancellationToken cancellationToken);
    }
}
