using System;

namespace abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory huawei = new HuaweiAbstractFactory();
            AbstractFactory apple = new AppleAbstractFactory();

            Console.WriteLine($"huawei Factory create {huawei.CreateComputer().GetComputerName()}  and {huawei.CreateSmartPhone().GetSmartPhoneName()} ");
            Console.WriteLine($"apple Factory create {apple.CreateComputer().GetComputerName()}  and {apple.CreateSmartPhone().GetSmartPhoneName()} ");
        }
    }
}