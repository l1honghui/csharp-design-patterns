using csharp_design_patterns.design_patterns.simple_factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_design_patterns.design_patterns._02_factory_method
{
    /// <summary>
    /// 工厂方法
    /// 工厂方法解决简单工厂一个类创建所有具体产品的硬编码强耦合，
    /// 将具体的工厂和产品解耦到子类实现，声明父类的抽象方法需求即可，这样就实现不修改父类代码又可通过子类来实现新产品的创建
    /// </summary>
    public abstract class FactoryMethod
    {
        public abstract Product CreateFactory();
    }

    public class HuaweiFactoryMethod : FactoryMethod
    {

        public override Product CreateFactory()
        {
            return new HuaWei();
        }
    }

    public class AppleFactoryMethod : FactoryMethod
    {

        public override Product CreateFactory()
        {
            return new Apple();
        }
    }

    public class SamsungFactoryMethod : FactoryMethod
    {

        public override Product CreateFactory()
        {
            return new Samsung();
        }
    }

    //如果我要添加一个新的产品 只需要重新创建一个产品工厂和产品类即可，而不用像简单工厂模式中那样去修改工厂类中的实现（具体指添加case语句)
    public class OppoFactoryMethod: FactoryMethod
    {
        public override Product CreateFactory()
        {
            return new Oppo();
        }
    }

    public class Oppo : Product
    {
        public override string GetProductName() => nameof(Oppo);
    }
}
