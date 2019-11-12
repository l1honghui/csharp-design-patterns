namespace builder
{
    /// <summary>
    /// 指导者
    /// 分解客户端后后端直接的构建者的操作，保证建造者按照某种顺序某些功能完成建造产品并
    /// </summary>
    public class Director
    {
        private readonly AbstractBuilder _abstractBuilder;

        public Director(AbstractBuilder abstractBuilder)
        {
            _abstractBuilder = abstractBuilder;
        }

        public void Constuct()
        {
            _abstractBuilder.BuildCpu();
            _abstractBuilder.BuildMemery();
            _abstractBuilder.BuildOS();
            _abstractBuilder.BuildOther();
        }

        public BuilderSmartPhone GetProduct() => _abstractBuilder.GetProduct();
    }
}
