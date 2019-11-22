using System;

namespace flyweight
{
    /*
     当程序需要大量对象时，享元模式非常有用。它提供了通过共享对象实例来减少资源使用量的方法。
     在此示例中[@link炼金术士商店] 的货架上有大量的药水。要填满货架 [@link炼金术士商店] 使用 [@link药水厂] （这表示此示例中的飞重量）。内部 [@link药水厂] 持有药水的字典集合，并在请求时懒创建对象。
     要在客户端和线程之间实现安全共享，享元对象必须是不可变的。享元对象是定义值对象。
     */
    class Program
    {
        static void Main(string[] args)
        {
            AlchemistShop alchemistShop = new AlchemistShop();
            alchemistShop.Enumerate();
        }
    }
}