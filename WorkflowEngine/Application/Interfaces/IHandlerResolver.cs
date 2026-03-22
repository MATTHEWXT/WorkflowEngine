namespace WorkflowEngine.Application.Interfaces
{
    public interface IHandlerResolver
    {
        ISystemTaskHandler Resolve(string handlerName);
    }
}
