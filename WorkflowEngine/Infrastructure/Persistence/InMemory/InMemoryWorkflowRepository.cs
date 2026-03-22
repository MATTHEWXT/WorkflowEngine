using System.Collections.Concurrent;
using WorkflowEngine.Application.Interfaces;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Infrastructure.Persistence.InMemory
{
    public class InMemoryWorkflowRepository : IWorkflowRepository
    {
        private readonly ConcurrentDictionary<Guid, WorkflowInstance> _store = new();

        public ValueTask SaveAsync(WorkflowInstance instance, CancellationToken cancellationToken)
        {
            _store[instance.Id] = instance;
            return ValueTask.CompletedTask;
        }

        public ValueTask<WorkflowInstance?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            _store.TryGetValue(id, out var wf);
            return ValueTask.FromResult(wf);
        }

        public ValueTask UpdateAsync(WorkflowInstance instance, CancellationToken cancellationToken)
        {
            _store[instance.Id] = instance;
            return ValueTask.CompletedTask;
        }
    }
}
