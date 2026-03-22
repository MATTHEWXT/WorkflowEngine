using System;
using System.Collections.Generic;
using System.Text;
using WorkflowEngine.Domain.Entities.Activity;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Application.Interfaces
{
    public interface TransitionHandler
    {

        ValueTask<IReadOnlyCollection<ActivityInstance>> GetNextActivitiesAsync(
            WorkflowInstance workflow,
            ActivityInstance current,
            ActivityResult result,
            CancellationToken cancellationToken);
    }
}
