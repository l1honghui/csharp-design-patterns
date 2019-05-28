namespace csharp_design_patterns.design_patterns.CreationPattern._03_abstract_factory
{
    /// <summary>
    /// 抽象工厂
    /// 工厂方法模式是为了克服简单工厂模式的缺点而设计出来的,简单工厂模式的工厂类随着产品类的增加需要增加额外的代码，
    /// 而工厂方法模式每个具体工厂类只完成单个实例的创建,所以它具有很好的可扩展性。
    /// 但是在实际生活中一个厂肯定不止一个产品，会有多个产品，如果我们要设计这样的系统时，工厂方法模式显然在这里不适用，而抽象工厂模式却可以很好地解决一系列产品创建的问题
    /// 缺点：可扩展性差，如果要加一个产品类别，就需要改动所有代码不利于扩展产品类，只适合扩展工厂
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract Computer CreateComputer();

        public abstract SmartPhone CreateSmartPhone();
    }

    public class HuaweiAbstractFactory : AbstractFactory
    {
        public override Computer CreateComputer() => new HuaweiComputer();

        public override SmartPhone CreateSmartPhone() => new HuaweiSmartPhone();
    }

    public class AppleAbstractFactory : AbstractFactory
    {
        public override Computer CreateComputer() => new AppleComputer();

        public override SmartPhone CreateSmartPhone() => new AppleSmartPhone();
    }

}
