using System;
using System.Linq;
using System.Reflection;

namespace csharp_design_patterns.design_patterns.singleton
{

    /// <summary>
    /// 单例的泛型版本，可以被子类继承
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class SingletonBase<T>
    {
        /// <summary>
        /// 同样使用Lazy确保实例的线程安全，并反射子类检查构造函数是否为私有无参构造函数，检查无误则创建实例对象
        /// </summary>
        private static readonly Lazy<T> _instance
          = new Lazy<T>(() =>
          {
              var ctors = typeof(T).GetConstructors(
                  BindingFlags.Instance
                  | BindingFlags.NonPublic
                  | BindingFlags.Public);
              if (ctors.Count() != 1)
                  throw new InvalidOperationException(String.Format("Type {0} must have exactly one constructor.", typeof(T)));
              var ctor = ctors.SingleOrDefault(c => c.GetParameters().Count() == 0 && c.IsPrivate);
              if (ctor == null)
                  throw new InvalidOperationException(String.Format("The constructor for {0} must be private and take no parameters.", typeof(T)));
              return (T)ctor.Invoke(null);
          });

        public static T Instance
        {
            get { return _instance.Value; }
        }
    }
}
