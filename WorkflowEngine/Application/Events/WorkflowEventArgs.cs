using System;
using System.Collections.Generic;
using System.Text;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Application.Events
{
    public class WorkflowEventArgs : EventArgs
    {      
        public WorkflowInstance Workflow {  get; }

        public WorkflowEventArgs(WorkflowInstance workflowInstance)
        {
            Workflow = workflowInstance;
        }
    }
}
