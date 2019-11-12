using System;

namespace simple_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Product huawei = SimpleFactory.GetProduct("huawei");
            Product apple = SimpleFactory.GetProduct("iphone");
            Product samsung = SimpleFactory.GetProduct("samsung");
            Console.WriteLine("huawei customer buy " + huawei.GetProductName());
            Console.WriteLine("iphone customer buy " + apple.GetProductName());
            Console.WriteLine("samsung customer buy " + samsung.GetProductName());
        }
    }
}