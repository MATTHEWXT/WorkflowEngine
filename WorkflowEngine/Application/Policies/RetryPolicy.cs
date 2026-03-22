using WorkflowEngine.Domain.Entities.Activity;

namespace WorkflowEngine.Application.Policies
{
    public class RetryPolicy 
    {
        public async ValueTask<ActivityResult> ExecuteAsync(
            Func<CancellationToken,
            ValueTask<ActivityResult>> action,
            CancellationToken cancellationToken)
        {
            int retries = 3;

            for (int i = 0; i < retries; i++)
            {
                try
                {
                    return await action(cancellationToken);
                }
                catch when (i < retries - 1)
                {
                    await Task.Delay(200 * (i + 1), cancellationToken);
                }
            }

            return new ActivityResult { Success = true };
        }
    }
}
