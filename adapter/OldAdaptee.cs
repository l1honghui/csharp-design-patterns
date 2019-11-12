using System;

namespace adapter
{
    /// <summary>
    /// 适配对象（Adaptee）
    /// </summary>
    public class OldAdaptee
    {
        /// <summary>
        /// 旧对象实现的功能
        /// </summary>
        public void Request()
        {
            Console.WriteLine("旧目标的功能");
        }
    }
}