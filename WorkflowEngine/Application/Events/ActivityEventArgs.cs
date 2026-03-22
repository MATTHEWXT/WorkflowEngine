using WorkflowEngine.Domain.Entities.Activity;

namespace WorkflowEngine.Application.Events
{
    public class ActivityEventArgs : EventArgs
    {        
        public ActivityInstance Activity {  get; }

        public ActivityEventArgs(ActivityInstance activity)
        {
            Activity = activity;
        }
    }
}
