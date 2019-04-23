using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_design_patterns.design_patterns.simple_factory
{
    /// <summary>
    /// 提供给客户选择的产品
    /// </summary>
    public abstract class Product
    {
        public abstract string GetProductName();
    }

    public class Apple : Product
    {
        public override string GetProductName() => nameof(Apple);
    }

    public class HuaWei : Product
    {
        public override string GetProductName() => nameof(HuaWei);
    }

    public class Samsung : Product
    {
        public override string GetProductName() => nameof(Samsung);
    }
}
