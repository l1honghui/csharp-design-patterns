namespace csharp_design_patterns.CreationType
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
