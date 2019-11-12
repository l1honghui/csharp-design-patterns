using System;

namespace factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod huawei = new HuaweiFactoryMethod();
            FactoryMethod oppo = new OppoFactoryMethod();

            Console.WriteLine("huawei Factory create " + huawei.CreateFactory().GetProductName());
            Console.WriteLine("oppo Factory create " + oppo.CreateFactory().GetProductName());
        }
    }
}