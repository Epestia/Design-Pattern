using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Singleton
{
    public sealed class MemoryCache
    {
        private Dictionary<string, object> _cacheObjects;
        public static Lazy<MemoryCache> _cache { get; } = new (() => new());
        public static MemoryCache Instance  => _cache.Value;
        private MemoryCache() {
            _cacheObjects = new();
        }
        public void Add(string key, object value) => _cacheObjects[key] = value;

        public object? Get(string Key)
        {
           if(_cacheObjects.ContainsKey(Key)) return _cacheObjects[Key];
            return null;
        }
    }
}
