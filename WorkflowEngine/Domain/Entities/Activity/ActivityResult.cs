using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowEngine.Domain.Entities.Activity
{
    public class ActivityResult
    {
        public bool Success { get; init; }
        public string? Message { get; init; }
        public object? Data { get; init; }
    }
}
