using System;
using System.Collections.Concurrent;

namespace _01_Singleton
{
    public sealed class MemoryCache
    {
        private readonly ConcurrentDictionary<string, object> _cache
            = new ConcurrentDictionary<string, object>();

        private static readonly Lazy<MemoryCache> _instance =
            new Lazy<MemoryCache>(() => new MemoryCache());

        public static MemoryCache Instance => _instance.Value;

        private MemoryCache() { }

        public void Add(string key, object value)
        {
            _cache[key] = value;
        }

        public object? Get(string key)
        {
            _cache.TryGetValue(key, out var value);
            return value;
        }
    }
}
