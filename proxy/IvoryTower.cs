using System;

namespace proxy
{
    /// <summary>
    /// 被代理的服务对象
    /// </summary>
    public class IvoryTower : IWizardTower
    {
        public void Enter(Wizard wizard)
        {
            Console.WriteLine("{0} enters the tower.", wizard);
        }
    }
}