using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_design_patterns.design_patterns.simple_factory
{
    /// <summary>
    /// 提供给客户选择的产品
    /// </summary>
    public interface IProduct
    {
        string GetProductName();
    }

    public class Iphone : IProduct
    {
        public string GetProductName() => nameof(Iphone);
    }

    public class HuaWei : IProduct
    {
        public string GetProductName() => nameof(HuaWei);
    }

    public class Samsung : IProduct
    {
        public string GetProductName() => nameof(Samsung);
    }
}
