using WorkflowEngine.Domain.Entities.Activity;

namespace WorkflowEngine.Application.Events
{
    public class ActivityEventArgs : EventArgs
    {        
        public ActivityInstance _activityInstance {  get; }

        public ActivityEventArgs(ActivityInstance activity)
        {
            _activityInstance = activity;
        }
    }
}
