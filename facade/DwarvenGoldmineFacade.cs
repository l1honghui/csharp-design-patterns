using System.Collections.Generic;

namespace facade
{
    public class DwarvenGoldmineFacade
    {
        private readonly List<DwarvenMineWorker> _workers;

        /**
         * Constructor.
         */
        public DwarvenGoldmineFacade()
        {
            _workers = new List<DwarvenMineWorker>
            {
                new DwarvenGoldDigger(),
                new DwarvenCartOperator(),
                new DwarvenTunnelDigger()
            };
        }

        public void StartNewDay()
        {
            MakeActions(_workers, new List<ActionEnum>
            {
                ActionEnum.WakeUp, ActionEnum.GoToMine
            });
        }

        public void DigOutGold()
        {
            MakeActions(_workers, new List<ActionEnum>
                {ActionEnum.Work});
        }

        public void EndDay()
        {
            MakeActions(_workers, new List<ActionEnum>
                {ActionEnum.GoHome, ActionEnum.GoToSleep});
        }

        private static void MakeActions(
            List<DwarvenMineWorker> workers,
            List<ActionEnum> actions
        )
        {
            foreach (DwarvenMineWorker worker in workers)
            {
                worker.Action(actions);
            }
        }
    }
}