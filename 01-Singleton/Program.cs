using _01_Singleton;

Console.WriteLine("Hello, World!");

var cache = MemoryCache.Instance;
var cache2 = MemoryCache.Instance;

cache.Add("test", DateTime.Now);
Console.WriteLine(cache2.Get("test"));

Console.WriteLine(ReferenceEquals(cache, cache2)); 
