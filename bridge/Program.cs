using System;

namespace bridge
{
    /*
    组合优于继承。
    桥模式也可以被认为是两个抽象层。
    使用Bridge，您可以将抽象与其实现解耦，从而使两者能够独立地变化。

    在桥模式中，抽象({@link IWeapon})和实现({@link IEnchantment})都有自己的类层次结构。
    实现的接口可以在不影响客户机的情况下进行更改。

    在本例中，我们有两个类层次结构。
    一个是武器，另一个是魔法。
    我们可以很容易地使用组合任何武器和任何魔法，而不是创建深层的类层次结构。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The knight receives an enchanted sword.");
            var enchantedSword = new Sword(new SoulEatingEnchantment());
            enchantedSword.Wield();
            enchantedSword.Swing();
            enchantedSword.UnWield();
        }
    }
}