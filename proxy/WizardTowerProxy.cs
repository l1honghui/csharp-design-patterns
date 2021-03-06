﻿using System;

namespace proxy
{
    /// <summary>
    /// 控制服务对象访问的代理
    /// </summary>
    public class WizardTowerProxy : IWizardTower
    {
        private static readonly int NumWizardsAllowed = 3;

        private int _numWizards = 0;

        private readonly IWizardTower _tower;

        /// <summary>
        /// 如果不需要客户端指定对应的被代理对象，可以将入参取消，对客户隐藏具体实现
        /// </summary>
        /// <param name="tower"></param>
        public WizardTowerProxy(IWizardTower tower)
        {
            this._tower = tower;
        }

        public void Enter(Wizard wizard)
        {
            if (_numWizards < NumWizardsAllowed)
            {
                _tower.Enter(wizard);
                _numWizards++;
            }
            else
            {
                Console.WriteLine("{0} is not allowed to enter!", wizard);
            }
        }
    }
}