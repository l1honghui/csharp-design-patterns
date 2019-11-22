using System;

namespace proxy
{
    /*
    代理，在其最一般的形式中，是一个类，它充当其他事物的接口。
    代理可以连接到任何东西:网络连接、内存中的大型对象、文件或其他一些昂贵或无法复制的资源。
    简而言之，代理是客户机调用的包装器或代理对象，以访问后台的实际服务对象。

    代理设计模式允许您通过创建包装器类作为代理来为其他对象提供接口。
    包装器类，也就是代理，可以在不改变对象代码的情况下向感兴趣的对象添加额外的功能。

    在本例中，代理({@link WizardTowerProxy})控制对实际对象({@link IvoryTower})的访问。
    */
    class Program
    {
        static void Main(string[] args)
        {
            WizardTowerProxy proxy = new WizardTowerProxy(new IvoryTower());
            proxy.Enter(new Wizard("Red wizard"));
            proxy.Enter(new Wizard("White wizard"));
            proxy.Enter(new Wizard("Black wizard"));
            proxy.Enter(new Wizard("Green wizard"));
            proxy.Enter(new Wizard("Brown wizard"));
        }
    }
}