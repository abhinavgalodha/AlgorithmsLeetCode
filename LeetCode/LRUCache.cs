using System.Collections.Generic;

namespace LeetCode
{
    public class LRUCache 
    {
        /*
        Design and implement a data structure for Least Recently Used (LRU) cache. It should support the following operations: get and put.

        get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
        put(key, value) - Set or insert the value if the key is not already present. When the cache reached its capacity, it should invalidate the least recently used item before inserting a new item.
        
        The cache is initialized with a positive capacity.
        
        Follow up:
        Could you do both operations in O(1) time complexity? 

         */

        private readonly Dictionary<int, int> _dictLRUCache; 
        private readonly int _capacity; 
        private readonly List<int> _leastRecentlyUsedArray; 

        public LRUCache(int capacity)
        {
            _leastRecentlyUsedArray = new List<int>(capacity);
            _capacity = capacity;
            _dictLRUCache = new Dictionary<int, int>(capacity);
        }
    
        public int Get(int key)
        {
            if (!_dictLRUCache.ContainsKey(key))
            {
                return -1;
            }

            _leastRecentlyUsedArray.Remove(key);
            _leastRecentlyUsedArray.Add(key);
            return _dictLRUCache[key];    
        }
    
        public void Put(int key, int value)
        {
            if (_dictLRUCache.ContainsKey(key))
            {
                _dictLRUCache[key] = value;
                _leastRecentlyUsedArray.Remove(key);
                _leastRecentlyUsedArray.Add(key);
            }
            else
            {
                var currentCapacity = _dictLRUCache.Count;
                if (currentCapacity == _capacity)
                {
                    var lruKey = _leastRecentlyUsedArray[0];
                    _leastRecentlyUsedArray.Remove(lruKey);
                    _dictLRUCache.Remove(lruKey);
                }
            
                _dictLRUCache.Add(key, value);
                _leastRecentlyUsedArray.Add(key);    
            }
        }
    }

}
