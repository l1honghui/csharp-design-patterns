using csharp_design_patterns.design_patterns;
using csharp_design_patterns.design_patterns._02_factory_method;
using csharp_design_patterns.design_patterns._03_abstract_factory;
using csharp_design_patterns.design_patterns.simple_factory;
using csharp_design_patterns.design_patterns.singleton;
using System;

namespace csharp_design_patterns
{
    class Program
    {
        private static void Main(string[] args)
        {
            TestAbstactFactory();
            Console.ReadKey();
        }

        private static void write(object obj)
        {
            Console.WriteLine(obj);
        }

        private static void TestSingleton()
        {
            write(Singleton.Instance.GetHashCode());
            write(Singleton.Instance.GetHashCode());
            write(SingletonBase<test>.Instance.GetHashCode());
            write(SingletonBase<test>.Instance.GetHashCode());
        }

        private static void TestSimpleFactory()
        {
            Product huawei = SimpleFactory.GetProduct("huawei");
            Product apple = SimpleFactory.GetProduct("iphone");
            Product samsung = SimpleFactory.GetProduct("samsung");
            write("huawei customer buy " + huawei.GetProductName());
            write("iphone customer buy " + apple.GetProductName());
            write("samsung customer buy " + samsung.GetProductName());
        }

        private static void TestFactoryMethod()
        {
            FactoryMethod huawei = new HuaweiFactoryMethod();
            FactoryMethod oppo = new OppoFactoryMethod();

            write("huawei Factory create " + huawei.CreateFactory().GetProductName());
            write("oppo Factory create " + oppo.CreateFactory().GetProductName());
        }

        private static void TestAbstactFactory()
        {
            AbstractFactory huawei = new HuaweiAbstractFactory();
            AbstractFactory apple = new AppleAbstractFactory();

            write($"huawei Factory create {huawei.CreateComputer().GetComputerName()}  and {huawei.CreateSmartPhone().GetSmartPhoneName()} ");
            write($"oppo Factory create {apple.CreateComputer().GetComputerName()}  and {apple.CreateSmartPhone().GetSmartPhoneName()} ");
        }
    }

    class test : SingletonBase<test>
    {
        private test() { }
    }
}
