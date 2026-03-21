using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowEngine.Application.Events
{
    public class UserTaskEventArgs : EventArgs
    {
        public Guid ActivityGuid { get; }
        public string AssinnedRole { get; }
        public string? AssinedUser { get; }

        public UserTaskEventArgs(Guid activityGuid, string assinedRole, string? assinedUser)
        {
            ActivityGuid = activityGuid;
            AssinnedRole = assinedRole;
            AssinedUser = assinedUser;
        }
    }
}
