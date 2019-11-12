using System;

namespace adapter
{
    /// <summary>
    /// 新目标对象，适配器模式中的目标(Target)角色，这里可以写成抽象类或者接口
    /// </summary>
    public abstract class NewTarget
    {
        /// <summary>
        /// 新目标对象实现的功能
        /// </summary>
        public virtual void Request()
        {
            Console.WriteLine("新的目标功能");
        }
    }
}