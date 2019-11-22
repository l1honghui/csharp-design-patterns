using System;

namespace decorator
{
    /*
     修饰器模式是子类更灵活的替代方法。修饰器类实现与目标相同的接口，并使用聚合来"修饰"对目标的调用。使用修饰器模式可以在运行时更改类的行为。
     在此示例中，我们展示了简单的 [@link SimpleTroll] 如何首先攻击然后逃离战斗。然后，我们用 [@link ClubbedTroll] 装饰 [@link SimpleTroll]，然后再次执行攻击。您可以看到装饰后行为的变化。
     */
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("A simple looking troll approaches.");
            ITroll troll = new SimpleTroll();
            troll.Attack();
            troll.FleeBattle();
            System.Console.WriteLine("Simple troll power {0}.\n", troll.GetAttackPower());

            // change the behavior of the simple troll by adding a decorator
            System.Console.WriteLine("A troll with huge club surprises you.");
            ITroll clubbedTroll = new ClubbedTroll(troll);
            clubbedTroll.Attack();
            clubbedTroll.FleeBattle();
            System.Console.WriteLine("Clubbed troll power {0}.\n", clubbedTroll.GetAttackPower());
        }
    }
}