using WorkflowEngine.Domain.Entities.Activity;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Application.Interfaces
{
    public interface ISystemTaskHandler
    {
        string Name { get; }

        ValueTask<ActivityResult> HandleAsync(
            IReadOnlyDictionary<string, object> parameters,
            WorkflowContext context,
            CancellationToken cancellationToken); 
    }
}
