namespace WorkflowEngine.Domain.Enums
{
    public enum ActivityType
    {
        UserTask,
        SystemTask,
        Decision,
        ParallelFork,
        ParallelJoin,
        SubWorkflow
    }
}
