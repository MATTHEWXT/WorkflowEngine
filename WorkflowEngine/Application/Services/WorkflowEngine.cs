
using WorkflowEngine.Application.Events;
using WorkflowEngine.Application.Interfaces;
using WorkflowEngine.Domain.Entities.Activity;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Application.Services
{
    public class WorkflowEngine : IWorkflowEngine
    {        
        public event EventHandler<ActivityEventArgs>? ActivityStarted;
        public event EventHandler<ActivityEventArgs>? ActivityCompleted;
        public event EventHandler<UserTaskEventArgs>? TaskAssigned;
        public event EventHandler<WorkflowEventArgs>? WorkflowCompleted;
        public event EventHandler<WorkflowEventArgs>? WorkflowFailed;

        public WorkflowEngine()
        {
        }

        public Task CancelWorkflowAsync(Guid workflowId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task CompleteActivityAsync(WorkflowInstance workflow, ActivityInstance activity, ActivityResult result, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task CompleteUserTaskAsync(Guid activityId, ActivityResult result, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task ExecuteActivityAsync(WorkflowInstance workflow, ActivityInstance activity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<WorkflowInstance> StartWorkflowAsync(WorkflowDefinition definition, WorkflowContext context, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
