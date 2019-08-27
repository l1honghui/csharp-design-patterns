using csharp_design_patterns.CreationType;
using System;

namespace csharp_design_patterns
{
    static class Program
    {
        private static void Main(string[] args)
        {
            TestBuilder();
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
            write(SingletonBase<Test>.Instance.GetHashCode());
            write(SingletonBase<Test>.Instance.GetHashCode());
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
            write($"apple Factory create {apple.CreateComputer().GetComputerName()}  and {apple.CreateSmartPhone().GetSmartPhoneName()} ");
        }

        private static void TestBuilder()
        {
            AbstractBuilder appleBuilder = new AppleBuilder();
            Director director = new Director(appleBuilder);
            director.Constuct();
            var prodcute = director.GetProduct();
            prodcute.ShowFunction();
        }
    }

    abstract class Test : SingletonBase<Test>
    {
        private Test() { }
    }
}
