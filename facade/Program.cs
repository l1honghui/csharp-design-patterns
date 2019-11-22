using System;

namespace facade
{
    /*
     当系统非常复杂或难以理解时，通常使用 Facade 设计模式，因为系统具有大量相互依赖的类或其源代码不可用。
     此模式隐藏了较大系统的复杂性，并为客户端提供了更简单的接口。它通常涉及单个包装类，该类包含客户端所需的一组成员。
     这些成员代表外观客户端访问系统并隐藏实现详细信息。
     在此示例中，Facade 是 （[@link DwarvenGoldmineFacade]），它提供了一个更简单的接口到金矿子系统。
     */
    class Program
    {
        static void Main(string[] args)
        {
            DwarvenGoldmineFacade facade = new DwarvenGoldmineFacade();
            facade.StartNewDay();
            facade.DigOutGold();
            facade.EndDay();
        }
    }
}