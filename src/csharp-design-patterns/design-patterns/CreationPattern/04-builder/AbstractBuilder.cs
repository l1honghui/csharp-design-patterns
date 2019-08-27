namespace csharp_design_patterns.CreationPattern
{
    /// <summary>
    /// 抽象建造器
    /// </summary>
    public abstract class AbstractBuilder
    {
        public abstract void BuildCpu();

        public abstract void BuildMemery();

        public abstract void BuildOS();

        public abstract void BuildOther();

        public abstract BuilderSmartPhone GetProduct();
    }
}
