using csharp_design_patterns.design_patterns;
using csharp_design_patterns.design_patterns.simple_factory;
using csharp_design_patterns.design_patterns.singleton;
using System;

namespace csharp_design_patterns
{
    class Program
    {
        private static void Main(string[] args)
        {
            TestSingleton();
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
            IProduct huawei = SimpleFactory.GetProduct("huawei");
            IProduct iphone = SimpleFactory.GetProduct("iphone");
            IProduct samsung = SimpleFactory.GetProduct("samsung");
            write("huawei customer buy " + huawei.GetProductName());
            write("iphone customer buy " + iphone.GetProductName());
            write("samsung customer buy " + samsung.GetProductName());
        }
    }

    class test : SingletonBase<test>
    {
        private test() { }
    }
}
