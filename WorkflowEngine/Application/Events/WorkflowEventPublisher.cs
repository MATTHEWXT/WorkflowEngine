using System;
using System.Collections.Generic;
using System.Text;
using WorkflowEngine.Application.Interfaces;
using WorkflowEngine.Domain.Entities.Activity;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Application.Events
{
    public class WorkflowEventPublisher : IWorkflowEventPubliser
    {
        public ValueTask PublishActivityCompetedAsync(ActivityInstance activity, ActivityResult result, CancellationToken cancelToken)
        {
            return ValueTask.CompletedTask;
        }

        public ValueTask PublishActivityStartedAsync(ActivityInstance activity, CancellationToken cancellationToken)
        {
            return ValueTask.CompletedTask;
        }

        public ValueTask PublishWorkflowCompetedAsync(WorkflowInstance workflow, CancellationToken cancellationToken)
        {
            return ValueTask.CompletedTask;
        }
    }
}
