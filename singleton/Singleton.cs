using System;

namespace csharp_design_patterns.CreationType
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// 因为构造函数是私有的，所以需要使用lambda，由于Lazy<T>默认的设置就是线程安全，所以不设置也是有效的
        /// </summary>
        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());

        /// <summary>
        /// 私有类，外部无法使用new创建对象实例
        /// </summary>
        private Singleton()
        {
        }

        /// <summary>
        /// 提供一个线程安全的全局唯一的实例，并提供一个访问他的全局访问出口
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }


}
