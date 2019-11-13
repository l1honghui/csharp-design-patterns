using System;
using System.Collections.Concurrent;

namespace object_pool
{
    public class DefaultObjectPool<T> : IObjectPool<T>
    {
        private readonly ConcurrentBag<T> _objects;
        private readonly Func<T> _objectGenerator;

        public DefaultObjectPool(Func<T> objectGenerator)
        {
            _objects = new ConcurrentBag<T>();
            _objectGenerator = objectGenerator ?? throw new ArgumentNullException("objectGenerator");
        }

        public int GetPoolSize()
        {
            return _objects.Count;
        }
        
        /// <summary>
        /// 使用池内对象
        /// </summary>
        /// <returns></returns>
        public T GetObject()
        {
            if (_objects.TryTake(out var item)) return item;
            return _objectGenerator();
        }

        /// <summary>
        /// 使用完后返回到对象池中
        /// </summary>
        /// <param name="item"></param>
        public void PutObject(T item)
        {
            _objects.Add(item);
        }
    }
}