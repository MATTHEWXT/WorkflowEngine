using WorkflowEngine.Application.Events;
using WorkflowEngine.Domain.Entities.Activity;
using WorkflowEngine.Domain.Entities.Workflow;

namespace WorkflowEngine.Application.Interfaces
{
    public interface IWorkflowEngine
    {
        /// <summary>
        /// Запуск нового workflow
        /// </summary>
        Task<WorkflowInstance> StartWorkflowAsync(
            WorkflowDefinition definition,
            WorkflowContext context,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Выполнение конкретного Activity
        /// </summary>
        Task ExecuteActivityAsync(
            WorkflowInstance workflow,
            ActivityInstance activity,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Завершение Activity с результатом
        /// </summary>
        Task CompleteActivityAsync(
            WorkflowInstance workflow,
            ActivityInstance activity,
            ActivityResult result,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Завершение пользовательской задачи (упрощённый внешний API)
        /// </summary>
        Task CompleteUserTaskAsync(
            Guid activityId,
            ActivityResult result,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Отмена workflow
        /// </summary>
        Task CancelWorkflowAsync(
            Guid workflowId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Срабатывает при старте Activity
        /// </summary>
        event EventHandler<ActivityEventArgs>? ActivityStarted;

        /// <summary>
        /// Срабатывает при завершении Activity
        /// </summary>
        event EventHandler<ActivityEventArgs>? ActivityCompleted;

        /// <summary>
        /// Срабатывает при назначении пользовательской задачи
        /// </summary>
        event EventHandler<UserTaskEventArgs>? TaskAssigned;

        /// <summary>
        /// Срабатывает при завершении workflow
        /// </summary>
        event EventHandler<WorkflowEventArgs>? WorkflowCompleted;

        /// <summary>
        /// Срабатывает при ошибке workflow (опционально)
        /// </summary>
        event EventHandler<WorkflowEventArgs>? WorkflowFailed;
    }
}
