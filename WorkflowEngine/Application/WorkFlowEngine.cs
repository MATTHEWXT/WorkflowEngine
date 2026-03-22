using System;
using System.Collections.Generic;
using System.Text;
using WorkflowEngine.Application.Events;
using WorkflowEngine.Application.Interfaces;
using WorkflowEngine.Domain.Entities.Activity;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Application
{
    public class WorkFlowEngine : IWorkflowEngine
    {
        private readonly IActivityExecutor _activityExecutor;
        private readonly ITransitionHandler _transitionHandler;

        public event EventHandler<ActivityEventArgs>? ActivityStarted;
        public event EventHandler<ActivityEventArgs>? ActivityCompleted;
        public event EventHandler<UserTaskEventArgs>? TaskAssigned;
        public event EventHandler<WorkflowEventArgs>? WorkflowCompleted;
        public event EventHandler<WorkflowEventArgs>? WorkflowFailed;

        public WorkFlowEngine(
            IActivityExecutor activityExecutor,
            ITransitionHandler transitionHandler)
        {
            _activityExecutor = activityExecutor;
            _transitionHandler = transitionHandler;
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
            var instance = new WorkflowInstance
            {
                Definition = definition,
                State = Domain.Enums.WorkflowState.Running
            };

            instance.Context = context;
        }
    }
}
