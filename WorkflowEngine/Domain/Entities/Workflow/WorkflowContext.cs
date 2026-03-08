using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace WorkflowEngine.Domain.Entities.Workflow
{
    public class WorkflowContext
    {
        private readonly ConcurrentDictionary<string, object> _data = new();

        public T Get<T>(string key) => (T)_data[key];
        public void Set<T>(string key, T value) => _data[key] = value;
        public bool TryGet<T>(string key, out T value)
        {
            if (_data.TryGetValue(key, out var obj) && obj is T t)
            {
                value = t;
                return true;
            }
            value = default;
            return false; 
        }
    }
}
